using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_KP_S39A2_AutoVermietung
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
                const double mwSt = 0.19;
                const double normTarif = 68;
                const double preisKm = 0.65;
                double gefKm = Convert.ToDouble(txtEingabeKm.Text);
                double rechnBetragNetto;
                double rechnBetragBrutto;
                double mwStEuro;

                //Ausgabewerte berechnen
                rechnBetragNetto = normTarif;
                if (gefKm > 200)
                    rechnBetragNetto = normTarif + (gefKm - 200) * preisKm;

                mwStEuro = rechnBetragNetto * mwSt;

                rechnBetragBrutto = rechnBetragNetto + mwStEuro;

                //Ausgabe der berechneten Werte
                txtAusgabeNetto.Text = rechnBetragNetto.ToString("0.00 €");
                txtAusgabeMwSt.Text = mwStEuro.ToString("0.00 €");
                txtAusgabeBrutto.Text = rechnBetragBrutto.ToString("0.00 €");

            }
            //Die Fehler mit Fehlermeldung auffangen
            catch(FormatException)
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
