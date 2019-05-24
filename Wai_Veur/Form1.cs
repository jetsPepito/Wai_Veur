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
        //Tableau des croisières
        Request[] TR = new Request[8];
        //nombre de croisières
        int nbR = 8;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Request[] TR = new Request[8];
        }
        '
        private void remplirTableau()
        {
            
            for (int i = 0; i < nbR; i++)
            {
                TR[i] = new Request(TbCity.Text, i);
            }
        }

        private void afficherListe()
        {
            lvCroisiere.Items.Clear();

            //affichage des croisières
            for (int i = 0; i < 8; i++)
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = TR[i].getTemp_C();
                ligne.SubItems.Add(TR[i].getDesc().ToString());
                ligne.SubItems.Add(TR[i].getTemp_C().ToString());
                ligne.SubItems.Add(TR[i].getWind().ToString());
                lvCroisiere.Items.Add(ligne);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lvCroisiere.Items.Clear();
            afficherListe();

            remplirTableau();


            /*switch (mainweather){
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
                    else if (desc == "")
                    {
                        
                    }
                    break;
                case "thunderstorm":
                    PBWeather.Load("images/flash.png");
                    break;}*/

        }
    }
}
