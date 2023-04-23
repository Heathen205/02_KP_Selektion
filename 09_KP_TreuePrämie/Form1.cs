using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_KP_TreuePrämie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double pr0bis5 = 1000;
            const double pr6bis10 = 1500;
            const double prRest = 2000;

            int jahren = Convert.ToInt32(txtEingabeJahren.Text);
            double prämiePro;
            

            if(jahren<=5)
            {
                prämiePro = pr0bis5;
            }
            else
            {
                if(jahren<=10)
                {
                    prämiePro = pr6bis10;
                }
                else
                {
                    prämiePro = prRest;
                }
            }
            txtAusgabePrämie.Text = prämiePro.ToString();
        }
    }
}
