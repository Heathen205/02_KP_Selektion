
namespace _04_KP_Schrauben
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
            this.txtEingabeStück = new System.Windows.Forms.TextBox();
            this.txtAusgbaeListenPreis = new System.Windows.Forms.TextBox();
            this.txtAusgabeRabatt = new System.Windows.Forms.TextBox();
            this.txtAusgabeGesamtPreis = new System.Windows.Forms.TextBox();
            this.txtAusgabeVersand = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeStück
            // 
            this.txtEingabeStück.Location = new System.Drawing.Point(396, 50);
            this.txtEingabeStück.Name = "txtEingabeStück";
            this.txtEingabeStück.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeStück.TabIndex = 0;
            // 
            // txtAusgbaeListenPreis
            // 
            this.txtAusgbaeListenPreis.Location = new System.Drawing.Point(189, 147);
            this.txtAusgbaeListenPreis.Name = "txtAusgbaeListenPreis";
            this.txtAusgbaeListenPreis.ReadOnly = true;
            this.txtAusgbaeListenPreis.Size = new System.Drawing.Size(100, 22);
            this.txtAusgbaeListenPreis.TabIndex = 1;
            // 
            // txtAusgabeRabatt
            // 
            this.txtAusgabeRabatt.Location = new System.Drawing.Point(189, 198);
            this.txtAusgabeRabatt.Name = "txtAusgabeRabatt";
            this.txtAusgabeRabatt.ReadOnly = true;
            this.txtAusgabeRabatt.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeRabatt.TabIndex = 2;
            // 
            // txtAusgabeGesamtPreis
            // 
            this.txtAusgabeGesamtPreis.Location = new System.Drawing.Point(189, 296);
            this.txtAusgabeGesamtPreis.Name = "txtAusgabeGesamtPreis";
            this.txtAusgabeGesamtPreis.ReadOnly = true;
            this.txtAusgabeGesamtPreis.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeGesamtPreis.TabIndex = 4;
            // 
            // txtAusgabeVersand
            // 
            this.txtAusgabeVersand.Location = new System.Drawing.Point(189, 245);
            this.txtAusgabeVersand.Name = "txtAusgabeVersand";
            this.txtAusgabeVersand.ReadOnly = true;
            this.txtAusgabeVersand.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeVersand.TabIndex = 3;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(203, 90);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(267, 37);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnung des Gesamtpreises";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(271, 365);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(140, 55);
            this.btnBeenden.TabIndex = 6;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stückzahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listenpreis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rabatt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Versandgebühr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gesamtpreis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabeGesamtPreis);
            this.Controls.Add(this.txtAusgabeVersand);
            this.Controls.Add(this.txtAusgabeRabatt);
            this.Controls.Add(this.txtAusgbaeListenPreis);
            this.Controls.Add(this.txtEingabeStück);
            this.Name = "Form1";
            this.Text = "Schrauben - Berechnung des Gesamtpreises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeStück;
        private System.Windows.Forms.TextBox txtAusgbaeListenPreis;
        private System.Windows.Forms.TextBox txtAusgabeRabatt;
        private System.Windows.Forms.TextBox txtAusgabeGesamtPreis;
        private System.Windows.Forms.TextBox txtAusgabeVersand;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

