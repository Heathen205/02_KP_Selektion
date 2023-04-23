
namespace _07_KP_Reise
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
            this.txtEingabeAlter = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetZwei = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetEinKind = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.txtAusgabeNetZweiEin = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeAlter
            // 
            this.txtEingabeAlter.Location = new System.Drawing.Point(501, 103);
            this.txtEingabeAlter.Name = "txtEingabeAlter";
            this.txtEingabeAlter.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeAlter.TabIndex = 0;
            // 
            // txtAusgabeNetZwei
            // 
            this.txtAusgabeNetZwei.Location = new System.Drawing.Point(501, 260);
            this.txtAusgabeNetZwei.Name = "txtAusgabeNetZwei";
            this.txtAusgabeNetZwei.ReadOnly = true;
            this.txtAusgabeNetZwei.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeNetZwei.TabIndex = 1;
            // 
            // txtAusgabeNetEinKind
            // 
            this.txtAusgabeNetEinKind.Location = new System.Drawing.Point(501, 305);
            this.txtAusgabeNetEinKind.Name = "txtAusgabeNetEinKind";
            this.txtAusgabeNetEinKind.ReadOnly = true;
            this.txtAusgabeNetEinKind.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeNetEinKind.TabIndex = 2;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(501, 398);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeBrutto.TabIndex = 4;
            // 
            // txtAusgabeNetZweiEin
            // 
            this.txtAusgabeNetZweiEin.Location = new System.Drawing.Point(501, 353);
            this.txtAusgabeNetZweiEin.Name = "txtAusgabeNetZweiEin";
            this.txtAusgabeNetZweiEin.ReadOnly = true;
            this.txtAusgabeNetZweiEin.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeNetZweiEin.TabIndex = 3;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(250, 157);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(237, 69);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnung der Preise";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pauschalreise: 2 Erwachsene und 1 Kind, 7 Tage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Geben Sie bitte das Alter des Kindes an:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Der Nettopreis für 2 Erwachsene beträgt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Der Nettopreis für 2 Erwachsene und ein Kind beträgt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Der Nettopreis für ein Kind beträgt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Der Bruttopreis für 2 Erwachsene und ein Kind beträgt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtAusgabeNetZweiEin);
            this.Controls.Add(this.txtAusgabeNetEinKind);
            this.Controls.Add(this.txtAusgabeNetZwei);
            this.Controls.Add(this.txtEingabeAlter);
            this.Name = "Form1";
            this.Text = "Pauschalreise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeAlter;
        private System.Windows.Forms.TextBox txtAusgabeNetZwei;
        private System.Windows.Forms.TextBox txtAusgabeNetEinKind;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.TextBox txtAusgabeNetZweiEin;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

