using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_KP_SwitchNoten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                const string text1 = "Sehr gut";
                const string text2 = "Gut";
                const string text3 = "Befriedigend";
                const string text4 = "ausreichend";
                const string text5 = "mangelhalft";
                const string text6 = "ungenügend";
                const string text0 = "s.B.";
                const string textDef = "unzulässige Note";

                int note = Convert.ToInt32(txtEingabe.Text);
                string notenText = "";

                switch(note)
                {
                    case 1:
                        notenText = text1;
                        break;

                    case 2:
                        notenText = text2;
                        break;

                    case 3:
                        notenText = text3;
                        break;

                    case 4:
                        notenText = text4;
                        break;

                    case 5:
                        notenText = text5;
                        break;

                    case 6:
                        notenText = text6;
                        break;

                    case 0:
                        notenText = text0;
                        break;

                    default:
                        notenText = textDef;
                        break;
                }

                txtAusgabe.Text = notenText;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Note ein!");
            }
        }
    }
}
