using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_KP_S42A1_Schrauben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                //Variablen deklarieren und initialisieren
                int schrauben = Convert.ToInt32(txtEingabeStückzahl.Text);

                //lokale Konstanten
                const int ohneKoRa = 0;
                const double preisStück = 0.20;
                const double rabatt = 0.05;

                
                double versandGebühr =0;
                double rabattWert;
                double gesamtPreis;
                double listenPreis;

                //Ausgabewerte berechnen
                listenPreis = schrauben * preisStück;
                    

                if (schrauben > 1000)
                {
                    versandGebühr = ohneKoRa;
                    rabattWert = listenPreis * rabatt;                 
                }

                
                else
                {
                    rabattWert = ohneKoRa;              
                }


                gesamtPreis = listenPreis + versandGebühr - rabattWert;

                //Ausgabe der berechneten Werte
                txtAusgabeListenpreis.Text = listenPreis.ToString("0.00 €");
                txtAusgabeRabatt.Text = rabattWert.ToString("0.00 €");
                txtAusgabeVersand.Text = versandGebühr.ToString("0.00 €");

                txtAusgabeGesamtpreis.Text = gesamtPreis.ToString("0.00 €");

            }
            //Fehler auffangen
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie Zahlenwerte ein!");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Bitte geben Sie kleinere Zahlenwerte ein!");
            }
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
