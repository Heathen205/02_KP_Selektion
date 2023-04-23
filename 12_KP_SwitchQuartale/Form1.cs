using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_KP_SwitchQuartale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] monat = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli","August","September",
                "Oktober","November","Dezember" };
            cmbMonat.Items.AddRange(monat);
            cmbMonat.SelectedIndex = 0;
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            const string Qu1 = "1. Quartal";
            const string Qu2 = "2. Quartal";
            const string Qu3 = "3.Quartal";
            const string def = "Ungültiger Name";
            string quartal = "";
            string monat = txtEingabeMonat.Text;

            switch(monat)
            {
                case "Januar":
                case "Februar":
                case "März":
                case "April":
                    quartal = Qu1;
                    break;

                case "Mai":
                case "Juni":
                case "Juli":
                case "August":
                    quartal = Qu2;
                    break;

                case "September":
                case "Oktober":
                case "November":
                case "Dezember":
                    quartal = Qu3;
                    break;

                default:
                    quartal = def;
                    break;
            }
            txtAusgabe1.Text = quartal;
        }

        private void btnAnzeigen2_Click(object sender, EventArgs e)
        {
            const string Qu1 = "1. Quartal";
            const string Qu2 = "2. Quartal";
            const string Qu3 = "3.Quartal";
            const string def = "Ungültiger Name";
            string quartal = "";
            string monat = cmbMonat.Text;

            switch (monat)
            {
                case "Januar":
                case "Februar":
                case "März":
                case "April":
                    quartal = Qu1;
                    break;

                case "Mai":
                case "Juni":
                case "Juli":
                case "August":
                    quartal = Qu2;
                    break;

                case "September":
                case "Oktober":
                case "November":
                case "Dezember":
                    quartal = Qu3;
                    break;

                default:
                    quartal = def;
                    break;
            }
            txtAusgabe2.Text = quartal;
        }
    }
}
