
namespace _02_KP_S38_Angebot
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
            this.txtEingabeTagen = new System.Windows.Forms.TextBox();
            this.txtEingabePersonen = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.txtBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aufenthaltsdauer in Tagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl der Personen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gesamtpreis Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gesamtpreis Brutto";
            // 
            // txtEingabeTagen
            // 
            this.txtEingabeTagen.Location = new System.Drawing.Point(319, 76);
            this.txtEingabeTagen.Name = "txtEingabeTagen";
            this.txtEingabeTagen.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeTagen.TabIndex = 4;
            this.txtEingabeTagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEingabePersonen
            // 
            this.txtEingabePersonen.Location = new System.Drawing.Point(319, 111);
            this.txtEingabePersonen.Name = "txtEingabePersonen";
            this.txtEingabePersonen.Size = new System.Drawing.Size(100, 20);
            this.txtEingabePersonen.TabIndex = 5;
            this.txtEingabePersonen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(319, 254);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto.TabIndex = 6;
            this.txtAusgabeNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(319, 289);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBrutto.TabIndex = 7;
            this.txtAusgabeBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBerechnen
            // 
            this.txtBerechnen.Location = new System.Drawing.Point(159, 190);
            this.txtBerechnen.Name = "txtBerechnen";
            this.txtBerechnen.Size = new System.Drawing.Size(164, 36);
            this.txtBerechnen.TabIndex = 8;
            this.txtBerechnen.Text = "Angebot berechnen";
            this.txtBerechnen.UseVisualStyleBackColor = true;
            this.txtBerechnen.Click += new System.EventHandler(this.txtBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBerechnen);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.txtEingabePersonen);
            this.Controls.Add(this.txtEingabeTagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Berechnen eines Angebots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEingabeTagen;
        private System.Windows.Forms.TextBox txtEingabePersonen;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.Button txtBerechnen;
    }
}

