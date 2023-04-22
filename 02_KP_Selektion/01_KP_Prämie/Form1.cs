using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_KP_Prämie
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
                //Konstanten deklarieren, die sich in Programmablauf nicht
                //verändern können
                const double basisPrämie = 0.015;
                const double mitZusatzPrämie = 0.02;//Basisprämie + Zusatzprämie

                //Nutzereingaben in eineer Variablen speichern
                double jahresUmsatz = Convert.ToDouble(txtEingabeUmsatz.Text);

                //zu berechnenden Variable deklarieren
                double prämie;

                //Berechnung der Basisprämie
                prämie = jahresUmsatz * basisPrämie;

                if(jahresUmsatz > 100000)
                {
                    prämie = jahresUmsatz * mitZusatzPrämie;
                }

                //Prämie ausgeben
                txtAusgabePrämie.Text = Math.Round(prämie, 2).ToString("0.00 €");

                
            }
            catch(FormatException)
            {
                MessageBox.Show("Bitte geben Sie Zahlenwert für den Umsatz ein.");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Die eingegebene Zahl ist zu groß." +
                    "Bitte geben Sie kleinren Zahlenwert ein!");
            }
        }
    }
}
