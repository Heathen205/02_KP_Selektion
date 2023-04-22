
namespace _03_KP_Autovermietung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.txtEingabeKilometer = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.txtAusgabeMwSt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normaltarif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "gefahrene Kilometer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechnungsbetrags netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rechnungbetrag brutto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "erhaltene Mehrwertsteuer";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(189, 158);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(170, 45);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Rechnungsbetrag berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(189, 403);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(186, 53);
            this.btnSchließen.TabIndex = 6;
            this.btnSchließen.Text = "Anwendung schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // txtEingabeKilometer
            // 
            this.txtEingabeKilometer.Location = new System.Drawing.Point(411, 97);
            this.txtEingabeKilometer.Name = "txtEingabeKilometer";
            this.txtEingabeKilometer.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeKilometer.TabIndex = 7;
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(411, 220);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeNetto.TabIndex = 8;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(411, 276);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeBrutto.TabIndex = 9;
            // 
            // txtAusgabeMwSt
            // 
            this.txtAusgabeMwSt.Location = new System.Drawing.Point(411, 338);
            this.txtAusgabeMwSt.Name = "txtAusgabeMwSt";
            this.txtAusgabeMwSt.ReadOnly = true;
            this.txtAusgabeMwSt.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeMwSt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 517);
            this.Controls.Add(this.txtAusgabeMwSt);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.txtEingabeKilometer);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autovermietung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.TextBox txtEingabeKilometer;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.TextBox txtAusgabeMwSt;
    }
}

