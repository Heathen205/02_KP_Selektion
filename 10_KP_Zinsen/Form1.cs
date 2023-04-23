using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_KP_Zinsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double zinsMin = 0.02;
            const double zinsMitte = 0.0225;
            const double zinsMax = 0.0275;
            const double zinsExt = 0.0025;

            const int min = 10000;
            const int max = 50000;

            double betrag = Convert.ToDouble(txtEingabe.Text);

            double zins;
            double zinssatz;
            double anzeigen;
            if(betrag <= min)
            {
                zinssatz = zinsMin;
            }
            else
            {
                if(betrag <= max)
                {
                    zinssatz = zinsMitte;
                }
                else
                {
                    zinssatz = zinsMax;
                }
            }

            if(rBtn2Jahre.Checked)
            {
                zinssatz = zinssatz + zinsExt;
            }

            zins = betrag * zinssatz;
            anzeigen = betrag + zins;
            if(chkAnzeigen.Checked)
            {
                MessageBox.Show(anzeigen.ToString());
            }
            txtAusgabe.Text = zins.ToString();
        }
    }
}
