
namespace _03_KP_S39A2_AutoVermietung
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
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEingabeKm = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.txtAusgabeMwSt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(106, 166);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(198, 23);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "Rechnungsbetrag berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(183, 359);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(121, 23);
            this.btnSchließen.TabIndex = 1;
            this.btnSchließen.Text = "Anwendung schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Normaltarif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "gefahrene Kilometer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rechnungsbetrag Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rechnungsbetrag Brutto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "erhaltene Mehrwertsteuer";
            // 
            // txtEingabeKm
            // 
            this.txtEingabeKm.Location = new System.Drawing.Point(372, 83);
            this.txtEingabeKm.Name = "txtEingabeKm";
            this.txtEingabeKm.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKm.TabIndex = 7;
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(372, 226);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto.TabIndex = 8;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(372, 262);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBrutto.TabIndex = 9;
            // 
            // txtAusgabeMwSt
            // 
            this.txtAusgabeMwSt.Location = new System.Drawing.Point(372, 298);
            this.txtAusgabeMwSt.Name = "txtAusgabeMwSt";
            this.txtAusgabeMwSt.ReadOnly = true;
            this.txtAusgabeMwSt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMwSt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabeMwSt);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.txtEingabeKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.btnBerechnen);
            this.Name = "Form1";
            this.Text = "Autovermietung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEingabeKm;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.TextBox txtAusgabeMwSt;
    }
}

