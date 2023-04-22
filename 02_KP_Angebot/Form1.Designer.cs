
namespace _02_KP_Angebot
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
            this.txtEingabeTagen = new System.Windows.Forms.TextBox();
            this.txtEingabePersonen = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEingabeTagen
            // 
            this.txtEingabeTagen.Location = new System.Drawing.Point(227, 58);
            this.txtEingabeTagen.Name = "txtEingabeTagen";
            this.txtEingabeTagen.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeTagen.TabIndex = 0;
            // 
            // txtEingabePersonen
            // 
            this.txtEingabePersonen.Location = new System.Drawing.Point(227, 119);
            this.txtEingabePersonen.Name = "txtEingabePersonen";
            this.txtEingabePersonen.Size = new System.Drawing.Size(100, 22);
            this.txtEingabePersonen.TabIndex = 1;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(227, 286);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeBrutto.TabIndex = 3;
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(227, 226);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeNetto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aufenthaltsdauer in Tagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anzahl der Personen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gesamtpreis brutto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gesamtpreis netto";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(80, 160);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(199, 49);
            this.btnBerechnen.TabIndex = 8;
            this.btnBerechnen.Text = "Angebot berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.txtEingabePersonen);
            this.Controls.Add(this.txtEingabeTagen);
            this.Name = "Form1";
            this.Text = "Berechnen eines Angebots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeTagen;
        private System.Windows.Forms.TextBox txtEingabePersonen;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBerechnen;
    }
}

