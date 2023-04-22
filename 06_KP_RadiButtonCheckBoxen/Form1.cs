using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_KP_RadiButtonCheckBoxen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbsenden_Click(object sender, EventArgs e)
        {
            try
            {
                const string textMännlich = "männlich, Kenntnisse in ";
                const string textWeib = "weiblich, Kenntnisse in ";
                const string textCPlus = "C++";
                const string textCSh = "C#";
                const string textJava = "Java";

                string ausgabeText ="";

                if(rBtnMann.Checked)
                {
                    ausgabeText = textMännlich;
                }
                if(rBtnWeib.Checked)
                {
                    ausgabeText = textWeib;
                }

                if(chkCPlus.Checked)
                {
                    ausgabeText += textCPlus;
                }
                if (chkCsharp.Checked)
                {
                    ausgabeText += textCSh;
                }
                if (chkJava.Checked)
                {
                    ausgabeText += textJava;
                }
                MessageBox.Show(ausgabeText);
            }
            catch
            {
                MessageBox.Show("Bitte treffen Sie eine Auswahl.");
            }
        }
    }
}
