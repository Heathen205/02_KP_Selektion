using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_KP_Schrauben
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
                const double preisSt = 0.20;
                const double rabatt = 0.05;
                const double versand = 5;

                int stück = Convert.ToInt32(txtEingabeStück.Text);
                double versandGebühr = 0;
                double listenPreis = 0;
                double rabattWert = 0;
                double gesamtPreis = 0;

                listenPreis = stück * preisSt;

                if(stück > 1000)
                {
                    versandGebühr = 0;
                    rabattWert = listenPreis * rabatt;
                    gesamtPreis = listenPreis - rabattWert;
                }
                else
                {
                    versandGebühr = versand;
                    rabattWert = 0;
                    gesamtPreis = listenPreis + versandGebühr;
                }

                txtAusgabeVersand.Text = versandGebühr.ToString("0.00 €");
                txtAusgbaeListenPreis.Text = listenPreis.ToString("0.00 €");
                txtAusgabeRabatt.Text = rabattWert.ToString("0.00 €");
                txtAusgabeGesamtPreis.Text = gesamtPreis.ToString("0.00 €");

            }
            catch
            {
                MessageBox.Show("Bitte geben Sie Stückzahl ein!");
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
