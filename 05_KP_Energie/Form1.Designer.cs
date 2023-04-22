
namespace _05_KP_Energie
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnJa = new System.Windows.Forms.RadioButton();
            this.rBtnNein = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEingabePersonen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEingabeWohnfläche = new System.Windows.Forms.TextBox();
            this.txtAusgabeVerbrauch = new System.Windows.Forms.TextBox();
            this.txtAusgabeTatsäch = new System.Windows.Forms.TextBox();
            this.txtAusgabeKennzahl = new System.Windows.Forms.TextBox();
            this.txtAusgabeHinweis = new System.Windows.Forms.TextBox();
            this.btnAuswerten = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEingabeVerbrauch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gesamtverbrauch in Liter oder m³";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnNein);
            this.groupBox1.Controls.Add(this.rBtnJa);
            this.groupBox1.Location = new System.Drawing.Point(75, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wird die Heizung für Warmwasser verwendet?";
            // 
            // rBtnJa
            // 
            this.rBtnJa.AutoSize = true;
            this.rBtnJa.Location = new System.Drawing.Point(240, 54);
            this.rBtnJa.Name = "rBtnJa";
            this.rBtnJa.Size = new System.Drawing.Size(44, 21);
            this.rBtnJa.TabIndex = 0;
            this.rBtnJa.Text = "Ja";
            this.rBtnJa.UseVisualStyleBackColor = true;
            // 
            // rBtnNein
            // 
            this.rBtnNein.AutoSize = true;
            this.rBtnNein.Location = new System.Drawing.Point(595, 54);
            this.rBtnNein.Name = "rBtnNein";
            this.rBtnNein.Size = new System.Drawing.Size(58, 21);
            this.rBtnNein.TabIndex = 1;
            this.rBtnNein.Text = "Nein";
            this.rBtnNein.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl Personen im Haushalt";
            // 
            // txtEingabePersonen
            // 
            this.txtEingabePersonen.Location = new System.Drawing.Point(336, 347);
            this.txtEingabePersonen.Name = "txtEingabePersonen";
            this.txtEingabePersonen.Size = new System.Drawing.Size(100, 22);
            this.txtEingabePersonen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wohlfläche in m²";
            // 
            // txtEingabeWohnfläche
            // 
            this.txtEingabeWohnfläche.Location = new System.Drawing.Point(770, 354);
            this.txtEingabeWohnfläche.Name = "txtEingabeWohnfläche";
            this.txtEingabeWohnfläche.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeWohnfläche.TabIndex = 5;
            // 
            // txtAusgabeVerbrauch
            // 
            this.txtAusgabeVerbrauch.Location = new System.Drawing.Point(315, 493);
            this.txtAusgabeVerbrauch.Name = "txtAusgabeVerbrauch";
            this.txtAusgabeVerbrauch.ReadOnly = true;
            this.txtAusgabeVerbrauch.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeVerbrauch.TabIndex = 6;
            // 
            // txtAusgabeTatsäch
            // 
            this.txtAusgabeTatsäch.Location = new System.Drawing.Point(315, 563);
            this.txtAusgabeTatsäch.Name = "txtAusgabeTatsäch";
            this.txtAusgabeTatsäch.ReadOnly = true;
            this.txtAusgabeTatsäch.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeTatsäch.TabIndex = 7;
            // 
            // txtAusgabeKennzahl
            // 
            this.txtAusgabeKennzahl.Location = new System.Drawing.Point(700, 493);
            this.txtAusgabeKennzahl.Name = "txtAusgabeKennzahl";
            this.txtAusgabeKennzahl.ReadOnly = true;
            this.txtAusgabeKennzahl.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeKennzahl.TabIndex = 8;
            // 
            // txtAusgabeHinweis
            // 
            this.txtAusgabeHinweis.Location = new System.Drawing.Point(315, 625);
            this.txtAusgabeHinweis.Name = "txtAusgabeHinweis";
            this.txtAusgabeHinweis.ReadOnly = true;
            this.txtAusgabeHinweis.Size = new System.Drawing.Size(485, 22);
            this.txtAusgabeHinweis.TabIndex = 9;
            // 
            // btnAuswerten
            // 
            this.btnAuswerten.Location = new System.Drawing.Point(222, 395);
            this.btnAuswerten.Name = "btnAuswerten";
            this.btnAuswerten.Size = new System.Drawing.Size(533, 53);
            this.btnAuswerten.TabIndex = 10;
            this.btnAuswerten.Text = "Auswertung des Energieverbrauchs";
            this.btnAuswerten.UseVisualStyleBackColor = true;
            this.btnAuswerten.Click += new System.EventHandler(this.btnAuswerten_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Verbrauch in kWh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "tatsächlicher Verbrauch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hinweis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kennzahl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "kWh/m²";
            // 
            // txtEingabeVerbrauch
            // 
            this.txtEingabeVerbrauch.Location = new System.Drawing.Point(407, 64);
            this.txtEingabeVerbrauch.Name = "txtEingabeVerbrauch";
            this.txtEingabeVerbrauch.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeVerbrauch.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 728);
            this.Controls.Add(this.txtEingabeVerbrauch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAuswerten);
            this.Controls.Add(this.txtAusgabeHinweis);
            this.Controls.Add(this.txtAusgabeKennzahl);
            this.Controls.Add(this.txtAusgabeTatsäch);
            this.Controls.Add(this.txtAusgabeVerbrauch);
            this.Controls.Add(this.txtEingabeWohnfläche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEingabePersonen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Energieverbrauchskennwert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnNein;
        private System.Windows.Forms.RadioButton rBtnJa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEingabePersonen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEingabeWohnfläche;
        private System.Windows.Forms.TextBox txtAusgabeVerbrauch;
        private System.Windows.Forms.TextBox txtAusgabeTatsäch;
        private System.Windows.Forms.TextBox txtAusgabeKennzahl;
        private System.Windows.Forms.TextBox txtAusgabeHinweis;
        private System.Windows.Forms.Button btnAuswerten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEingabeVerbrauch;
    }
}

