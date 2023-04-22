using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_KP_S38_Angebot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                //die konstante Variablen deklarieren
                const double zimmerPreis = 70;
                const double mwSt = 0.19;
                const double extra = 20;
                //Variablen deklarieren und initialisieren
                int anzahlPersonen = Convert.ToInt32(txtEingabePersonen.Text);
                double aufenthaltsDauer = Convert.ToDouble(txtEingabeTagen.Text);

                //zu berechnende Variablen deklarieren
                double brutto = 0;
                double netto = 0;

                //Die Werte berechnen
                netto = zimmerPreis * aufenthaltsDauer * anzahlPersonen;
                if (aufenthaltsDauer == 1)
                    netto = netto + extra;

                brutto = netto + netto * mwSt;

                //Die Werte ausgeben
                txtAusgabeBrutto.Text = brutto.ToString("0.00 €");
                txtAusgabeNetto.Text = netto.ToString("0.00 €");
            }

            //Die Fehler auffangen mit Fehlermeldung
            catch(FormatException)
            {
                MessageBox.Show("Bitte geben Sie Zahlenwerte ein!");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Bitte geben Sie kleinere Zahlenwerte ein!");
            }
        }
    }
}
