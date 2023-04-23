using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_KP_Reise
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
                const double zimmerPreis = 50;
                const double mwSt = 0.19;

                const int anzahlPers = 2;
                const int aufeDau = 7;

                const double rabatt0bis6 = 1;
                const double rabatt7bis11 = 0.3;
                const double rabattRest = 0.7;
                const int grenzeBaby = 6;
                const int grenzeKind = 11;
                const int hundertProz = 1;

                double rabatt = 0;
                double nettoErwachsene;
                double nettoKind;
                double nettoGes;
                double bruttoGes;

                int alterKind = Convert.ToInt32(txtEingabeAlter.Text);

                if(alterKind < grenzeBaby)
                {
                    rabatt = rabatt0bis6;
                }
                else
                {
                    if(alterKind <= grenzeKind)
                    {
                        rabatt = rabatt7bis11;
                    }
                    else
                    {
                        rabatt = rabattRest;
                    }
                }
                nettoKind = aufeDau * zimmerPreis * (hundertProz - rabatt);
                nettoErwachsene = aufeDau * zimmerPreis * anzahlPers;
                nettoGes = nettoKind + nettoErwachsene;
                bruttoGes = nettoGes + (nettoGes * mwSt);

                txtAusgabeNetZwei.Text = nettoErwachsene.ToString("0.00");
                txtAusgabeNetEinKind.Text = nettoKind.ToString("0.00");
                txtAusgabeNetZweiEin.Text = nettoGes.ToString("0.00");
                txtAusgabeBrutto.Text = bruttoGes.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie das Alter Ihres Kindes ein!");
            }
        }
    }
}
