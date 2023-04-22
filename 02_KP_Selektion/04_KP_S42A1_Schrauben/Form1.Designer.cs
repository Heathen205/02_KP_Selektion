
namespace _04_KP_S42A1_Schrauben
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
            this.txtEingabeStückzahl = new System.Windows.Forms.TextBox();
            this.txtAusgabeListenpreis = new System.Windows.Forms.TextBox();
            this.txtAusgabeRabatt = new System.Windows.Forms.TextBox();
            this.txtAusgabeVersand = new System.Windows.Forms.TextBox();
            this.txtAusgabeGesamtpreis = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stückzahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listenpreis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rabatt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Versandgebühr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gesamtpreis";
            // 
            // txtEingabeStückzahl
            // 
            this.txtEingabeStückzahl.Location = new System.Drawing.Point(299, 61);
            this.txtEingabeStückzahl.Name = "txtEingabeStückzahl";
            this.txtEingabeStückzahl.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeStückzahl.TabIndex = 5;
            // 
            // txtAusgabeListenpreis
            // 
            this.txtAusgabeListenpreis.Location = new System.Drawing.Point(299, 193);
            this.txtAusgabeListenpreis.Name = "txtAusgabeListenpreis";
            this.txtAusgabeListenpreis.ReadOnly = true;
            this.txtAusgabeListenpreis.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeListenpreis.TabIndex = 6;
            // 
            // txtAusgabeRabatt
            // 
            this.txtAusgabeRabatt.Location = new System.Drawing.Point(299, 237);
            this.txtAusgabeRabatt.Name = "txtAusgabeRabatt";
            this.txtAusgabeRabatt.ReadOnly = true;
            this.txtAusgabeRabatt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeRabatt.TabIndex = 7;
            // 
            // txtAusgabeVersand
            // 
            this.txtAusgabeVersand.Location = new System.Drawing.Point(299, 280);
            this.txtAusgabeVersand.Name = "txtAusgabeVersand";
            this.txtAusgabeVersand.ReadOnly = true;
            this.txtAusgabeVersand.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeVersand.TabIndex = 8;
            // 
            // txtAusgabeGesamtpreis
            // 
            this.txtAusgabeGesamtpreis.Location = new System.Drawing.Point(299, 330);
            this.txtAusgabeGesamtpreis.Name = "txtAusgabeGesamtpreis";
            this.txtAusgabeGesamtpreis.ReadOnly = true;
            this.txtAusgabeGesamtpreis.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeGesamtpreis.TabIndex = 9;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(220, 144);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(257, 23);
            this.btnBerechnen.TabIndex = 10;
            this.btnBerechnen.Text = "Berechnung des Gesamtpreises";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(283, 388);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(162, 23);
            this.btnSchließen.TabIndex = 11;
            this.btnSchließen.Text = "Beenden";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabeGesamtpreis);
            this.Controls.Add(this.txtAusgabeVersand);
            this.Controls.Add(this.txtAusgabeRabatt);
            this.Controls.Add(this.txtAusgabeListenpreis);
            this.Controls.Add(this.txtEingabeStückzahl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Schrauben - Berechnung des Gesamtpreises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEingabeStückzahl;
        private System.Windows.Forms.TextBox txtAusgabeListenpreis;
        private System.Windows.Forms.TextBox txtAusgabeRabatt;
        private System.Windows.Forms.TextBox txtAusgabeVersand;
        private System.Windows.Forms.TextBox txtAusgabeGesamtpreis;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchließen;
    }
}

