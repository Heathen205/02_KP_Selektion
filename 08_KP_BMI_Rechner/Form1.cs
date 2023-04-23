using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KP_BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double grenzeMin = 18.5;
            const double grenzeMax = 25;
            double meter = Convert.ToDouble(txtEingabeMeter.Text);
            double gewicht = Convert.ToDouble(txtEingabeGewicht.Text);
            double bmi;
            string textUnter = "Sie sind untergewicht.";
            string textNormal = "Sie sind normalgewicht.";
            string textÜber = "Sie sind übergewicht.";
            string hinweis;

            bmi = gewicht / Math.Pow(meter, 2);

            if(bmi < grenzeMin)
            {
                hinweis = textUnter;
            }
            else
            {
                if(bmi>grenzeMax)
                {
                    hinweis = textÜber;
                }
                else
                {
                    hinweis = textNormal;
                }
            }

            txtAusgabeBmi.Text = bmi.ToString("0.00");
            txtAusgabeHinweis.Text = hinweis;
        }
    }
}
