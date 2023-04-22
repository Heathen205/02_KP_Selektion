using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_KP_S42A2_Energie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            try
            {
                //Variablen deklarieren und initialisieren
                int gesamtVerbrauch = Convert.ToInt16(txtEingabeGesVerb.Text);
                int anzahlPers = Convert.ToInt16(txtEingabePerso.Text);
                int wohnFläche = Convert.ToInt16(txtEingabeWoFl.Text);

                //Konstante Werte
                const int grenzWert = 120;
                const int multiplikator = 10;
                const int kwhMulti = 1000;
                const string textGut = "Haus hat einen guten termischen Wert.";
                const string textSchlecht = "Sie sollten über eine Sanierung nachdenken.";

                //zu berechnende Variablen deklarieren
                int gesamtVerbrKwh;
                int tatsVerbrauch;
                int kennZahl;

                //Berechnung der Werte
                gesamtVerbrKwh = gesamtVerbrauch * multiplikator;

                tatsVerbrauch = gesamtVerbrKwh;

                if(rBtnJa.Checked)
                {
                    tatsVerbrauch = gesamtVerbrKwh - (anzahlPers * kwhMulti);
                }

                kennZahl = tatsVerbrauch / grenzWert;

                if(kennZahl < grenzWert)
                {
                    txtAusgabeHinweis.Text = textGut;
                }

                else
                {
                    txtAusgabeHinweis.Text = textSchlecht;
                }

                //Die Werte ausgeben
                txtAusgabeKennzahl.Text = kennZahl.ToString();
                txtAusgabeVerbra.Text = gesamtVerbrKwh.ToString();
                txtAusgabeTatVerb.Text = tatsVerbrauch.ToString();
            }
            //Fehler auffangen
            catch(FormatException)
            {
                MessageBox.Show("Bitte geben Sie Zahlenwerte in allen Eingabefelder ein.");
            }

            catch(OverflowException)
            {
                MessageBox.Show("Bitte geben Sie kleinere Zahlenwerte ein.");
            }
        }
    }
}
