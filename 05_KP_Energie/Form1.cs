using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_KP_Energie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            double verbrauchLit = Convert.ToDouble(txtEingabeVerbrauch.Text);
            double person = Convert.ToDouble(txtEingabePersonen.Text);
            double wohnFläche = Convert.ToDouble(txtEingabeWohnfläche.Text);

            const int grenzWert = 120;
            const int kwhMulti = 1000;
            const int multipli = 10;
            const string txtGut = "Ihr Haus hat eine guten themischen Wert!";
            const string txtSchlect = "Sie sollten über eine Sanierung nachdenken!";

            double verbrauchKwh = 0;
            double tatVerb = 0;
            double kennzahl = 0;

            verbrauchKwh = verbrauchLit * multipli;
            tatVerb = verbrauchKwh;

            if(rBtnJa.Checked)
            {
                tatVerb = verbrauchKwh - (person * kwhMulti);
            }
            kennzahl = tatVerb / grenzWert;

            if(kennzahl < grenzWert)
            {
                txtAusgabeHinweis.Text = txtGut;
            }
            else
            {
                txtAusgabeHinweis.Text = txtSchlect;
            }

            txtAusgabeKennzahl.Text = kennzahl.ToString();
            txtAusgabeTatsäch.Text = tatVerb.ToString();
            txtAusgabeVerbrauch.Text = verbrauchKwh.ToString();
        }
    }
}
