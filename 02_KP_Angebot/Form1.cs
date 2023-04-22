using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_KP_Angebot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double preis = 70;
            double tage = Convert.ToDouble(txtEingabeTagen.Text);
            double anzahl = Convert.ToDouble(txtEingabePersonen.Text);
            double extra = 20;
            double netto = 0;
            double brutto = 0;
            double mwSt = 1.19;

            netto = tage * anzahl * preis;

            if(tage == 1)
            {
                netto = tage * anzahl * preis + extra;
            }

            brutto = netto * mwSt;

            txtAusgabeNetto.Text = netto.ToString();
            txtAusgabeBrutto.Text = brutto.ToString();
        }
    }
}
