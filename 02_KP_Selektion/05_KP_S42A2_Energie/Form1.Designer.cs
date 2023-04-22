
namespace _05_KP_S42A2_Energie
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEingabeGesVerb = new System.Windows.Forms.TextBox();
            this.txtEingabePerso = new System.Windows.Forms.TextBox();
            this.txtEingabeWoFl = new System.Windows.Forms.TextBox();
            this.txtAusgabeVerbra = new System.Windows.Forms.TextBox();
            this.txtAusgabeTatVerb = new System.Windows.Forms.TextBox();
            this.txtAusgabeKennzahl = new System.Windows.Forms.TextBox();
            this.txtAusgabeHinweis = new System.Windows.Forms.TextBox();
            this.rBtnJa = new System.Windows.Forms.RadioButton();
            this.rBtnNein = new System.Windows.Forms.RadioButton();
            this.btnAuswerten = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gesamtverbrauch in Liter oder m³";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anzahl Personen im Haushalt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wohnfläche in m²";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verbrauch in kWh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "tatsächlicher Verbrauch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kennzahl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "kWh/m²";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hinweis";
            // 
            // txtEingabeGesVerb
            // 
            this.txtEingabeGesVerb.Location = new System.Drawing.Point(280, 57);
            this.txtEingabeGesVerb.Name = "txtEingabeGesVerb";
            this.txtEingabeGesVerb.Size = new System.Drawing.Size(146, 20);
            this.txtEingabeGesVerb.TabIndex = 11;
            // 
            // txtEingabePerso
            // 
            this.txtEingabePerso.Location = new System.Drawing.Point(280, 207);
            this.txtEingabePerso.Name = "txtEingabePerso";
            this.txtEingabePerso.Size = new System.Drawing.Size(100, 20);
            this.txtEingabePerso.TabIndex = 12;
            // 
            // txtEingabeWoFl
            // 
            this.txtEingabeWoFl.Location = new System.Drawing.Point(583, 207);
            this.txtEingabeWoFl.Name = "txtEingabeWoFl";
            this.txtEingabeWoFl.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeWoFl.TabIndex = 13;
            // 
            // txtAusgabeVerbra
            // 
            this.txtAusgabeVerbra.Location = new System.Drawing.Point(219, 328);
            this.txtAusgabeVerbra.Name = "txtAusgabeVerbra";
            this.txtAusgabeVerbra.ReadOnly = true;
            this.txtAusgabeVerbra.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeVerbra.TabIndex = 14;
            // 
            // txtAusgabeTatVerb
            // 
            this.txtAusgabeTatVerb.Location = new System.Drawing.Point(219, 377);
            this.txtAusgabeTatVerb.Name = "txtAusgabeTatVerb";
            this.txtAusgabeTatVerb.ReadOnly = true;
            this.txtAusgabeTatVerb.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeTatVerb.TabIndex = 15;
            // 
            // txtAusgabeKennzahl
            // 
            this.txtAusgabeKennzahl.Location = new System.Drawing.Point(454, 377);
            this.txtAusgabeKennzahl.Name = "txtAusgabeKennzahl";
            this.txtAusgabeKennzahl.ReadOnly = true;
            this.txtAusgabeKennzahl.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeKennzahl.TabIndex = 16;
            // 
            // txtAusgabeHinweis
            // 
            this.txtAusgabeHinweis.Location = new System.Drawing.Point(219, 443);
            this.txtAusgabeHinweis.Name = "txtAusgabeHinweis";
            this.txtAusgabeHinweis.ReadOnly = true;
            this.txtAusgabeHinweis.Size = new System.Drawing.Size(287, 20);
            this.txtAusgabeHinweis.TabIndex = 17;
            // 
            // rBtnJa
            // 
            this.rBtnJa.AutoSize = true;
            this.rBtnJa.Location = new System.Drawing.Point(272, 25);
            this.rBtnJa.Name = "rBtnJa";
            this.rBtnJa.Size = new System.Drawing.Size(36, 17);
            this.rBtnJa.TabIndex = 18;
            this.rBtnJa.TabStop = true;
            this.rBtnJa.Text = "Ja";
            this.rBtnJa.UseVisualStyleBackColor = true;
            // 
            // rBtnNein
            // 
            this.rBtnNein.AutoSize = true;
            this.rBtnNein.Location = new System.Drawing.Point(399, 25);
            this.rBtnNein.Name = "rBtnNein";
            this.rBtnNein.Size = new System.Drawing.Size(47, 17);
            this.rBtnNein.TabIndex = 19;
            this.rBtnNein.TabStop = true;
            this.rBtnNein.Text = "Nein";
            this.rBtnNein.UseVisualStyleBackColor = true;
            // 
            // btnAuswerten
            // 
            this.btnAuswerten.Location = new System.Drawing.Point(72, 262);
            this.btnAuswerten.Name = "btnAuswerten";
            this.btnAuswerten.Size = new System.Drawing.Size(502, 23);
            this.btnAuswerten.TabIndex = 20;
            this.btnAuswerten.Text = "Auswertung des Energieverbrauchs";
            this.btnAuswerten.UseVisualStyleBackColor = true;
            this.btnAuswerten.Click += new System.EventHandler(this.btnAuswerten_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnJa);
            this.groupBox1.Controls.Add(this.rBtnNein);
            this.groupBox1.Location = new System.Drawing.Point(72, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 57);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wird die Heizung für Warmwasser verwendet?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAuswerten);
            this.Controls.Add(this.txtAusgabeHinweis);
            this.Controls.Add(this.txtAusgabeKennzahl);
            this.Controls.Add(this.txtAusgabeTatVerb);
            this.Controls.Add(this.txtAusgabeVerbra);
            this.Controls.Add(this.txtEingabeWoFl);
            this.Controls.Add(this.txtEingabePerso);
            this.Controls.Add(this.txtEingabeGesVerb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEingabeGesVerb;
        private System.Windows.Forms.TextBox txtEingabePerso;
        private System.Windows.Forms.TextBox txtEingabeWoFl;
        private System.Windows.Forms.TextBox txtAusgabeVerbra;
        private System.Windows.Forms.TextBox txtAusgabeTatVerb;
        private System.Windows.Forms.TextBox txtAusgabeKennzahl;
        private System.Windows.Forms.TextBox txtAusgabeHinweis;
        private System.Windows.Forms.RadioButton rBtnJa;
        private System.Windows.Forms.RadioButton rBtnNein;
        private System.Windows.Forms.Button btnAuswerten;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

