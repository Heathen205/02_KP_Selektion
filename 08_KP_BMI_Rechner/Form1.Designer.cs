
namespace _08_KP_BMI_Rechner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEingabeMeter = new System.Windows.Forms.TextBox();
            this.txtEingabeGewicht = new System.Windows.Forms.TextBox();
            this.txtAusgabeHinweis = new System.Windows.Forms.TextBox();
            this.txtAusgabeBmi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(178, 206);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(235, 57);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "BMI berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Körpergröße in meter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gewicht in Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interpretation des BMI Wertes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "BMI";
            // 
            // txtEingabeMeter
            // 
            this.txtEingabeMeter.Location = new System.Drawing.Point(431, 93);
            this.txtEingabeMeter.Name = "txtEingabeMeter";
            this.txtEingabeMeter.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeMeter.TabIndex = 5;
            // 
            // txtEingabeGewicht
            // 
            this.txtEingabeGewicht.Location = new System.Drawing.Point(431, 156);
            this.txtEingabeGewicht.Name = "txtEingabeGewicht";
            this.txtEingabeGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeGewicht.TabIndex = 6;
            // 
            // txtAusgabeHinweis
            // 
            this.txtAusgabeHinweis.Location = new System.Drawing.Point(431, 350);
            this.txtAusgabeHinweis.Name = "txtAusgabeHinweis";
            this.txtAusgabeHinweis.ReadOnly = true;
            this.txtAusgabeHinweis.Size = new System.Drawing.Size(242, 22);
            this.txtAusgabeHinweis.TabIndex = 8;
            // 
            // txtAusgabeBmi
            // 
            this.txtAusgabeBmi.Location = new System.Drawing.Point(431, 287);
            this.txtAusgabeBmi.Name = "txtAusgabeBmi";
            this.txtAusgabeBmi.ReadOnly = true;
            this.txtAusgabeBmi.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeBmi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabeHinweis);
            this.Controls.Add(this.txtAusgabeBmi);
            this.Controls.Add(this.txtEingabeGewicht);
            this.Controls.Add(this.txtEingabeMeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEingabeMeter;
        private System.Windows.Forms.TextBox txtEingabeGewicht;
        private System.Windows.Forms.TextBox txtAusgabeHinweis;
        private System.Windows.Forms.TextBox txtAusgabeBmi;
    }
}

