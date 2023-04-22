using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_KP_Autovermietung
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
                const double mwSt = 0.19;
                const double normTarif = 68;
                const double preisKm = 0.65;
                double km = Convert.ToDouble(txtEingabeKilometer.Text);
                double netto = 0;
                double brutto = 0;
                double mwStEuro = 0;

                netto = normTarif;
                if(km > 200)
                {
                    netto = normTarif + (km - 200) * preisKm;
                }
                mwStEuro = netto * mwSt;
                brutto = netto + mwStEuro;

                txtAusgabeNetto.Text = netto.ToString("0.00");
                txtAusgabeBrutto.Text = brutto.ToString("0.00");
                txtAusgabeMwSt.Text = mwStEuro.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie Zahlenwerte für Kilometer ein!");
            }
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
