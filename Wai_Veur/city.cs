using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Json.Net;
using System.Net;

namespace Wai_Veur
{
    class Request
    {
        private string dt_text; //hour
        private string city;
        private string temp_k;
        private string mainweather;
        private string desc;
        private string wind;
        private int idx;

        public Request( string uneCity , int unIdx)
        {
            this.city = uneCity;
            this.idx = unIdx;
            string url = "https://openweathermap.org/data/2.5/forecast?q="+city+"&appid=b6907d289e10d714a6e88b30761fae22";

            //Extraction du json et convertion
            string json = new WebClient().DownloadString(url);
            dynamic jsonObject = JsonConvert.DeserializeObject(json);

            //Récupération des données
            //this.dt_text = jsonObject.list[unIdx].dt_text.ToString();
            this.mainweather = jsonObject.list[unIdx].weather[0].main.ToString();
            this.temp_k = jsonObject.list[unIdx].main.temp.ToString();
            this.wind = jsonObject.list[unIdx].wind.speed.ToString();
            this.desc = jsonObject.list[unIdx].weather[0].description.ToString();
        }  
        public string getCity()
        {
            return this.city;
        }
        public string getDt_Text()
        {
            return this.dt_text;
        }
        public string getTemp_C()
        {
            double temp_d = double.Parse(this.temp_k) - 273;
            double temp_dd = Math.Round((temp_d), 0);
            string temp_c = temp_dd.ToString();
            return temp_c;
        }

        public string getMainweather()
        {
            return this.mainweather;
        }

        public string getWind()
        {
            return this.wind;
        }

        public string getDesc()
        {
            return this.desc;
        }
    }
}
