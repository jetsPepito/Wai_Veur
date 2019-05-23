using System;
using System.Net;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Json.Net;


namespace Wai_Veur
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string city = TxtCity.Text;
            string url = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=46e41fd0cd8c502f7e54d2615621026f";

            //Extraction du json et convertion
            string json = new WebClient().DownloadString(url);
            dynamic jsonObject = JsonConvert.DeserializeObject(json);

            //Récupération des données
            string mainweather = jsonObject.weather[0].main.ToString();
            string temp_k = jsonObject.main.temp.ToString();
            double temp_d = double.Parse(temp_k) - 273;
            double temp_dd = Math.Round((temp_d), 0);
            string temp_c = temp_dd.ToString();
            string wind = jsonObject.wind.speed.ToString();
            string desc = jsonObject.weather[0].description.ToString();


            TbWeather.Text = desc;
            TBTemp.Text = temp_c;
            TBCity.Text = city;
            TbWind.Text = wind + "m/s";

            switch (mainweather){
                case "Clouds":
                    PBWeather.Load("images/cloud.png");
                    break;
                case "Clear":
                    PBWeather.Load("images/sunny.png");
                    break;
                case "Rain":
                    if (desc == "light rain")
                    {
                        PBWeather.Load("images/drop.png");
                    }
                    else if (desc == "") ;
                    break;
                case "thunderstorm":
                    PBWeather.Load("images/flash.png");
                    break;
            }
        }
    }
}
