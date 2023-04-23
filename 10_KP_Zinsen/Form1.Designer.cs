
namespace _10_KP_Zinsen
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
            this.chkAnzeigen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtn2Jahre = new System.Windows.Forms.RadioButton();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(255, 296);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(197, 61);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "Berechnung der jährliche Zinszahlung";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anlagebetrag in Euro";
            // 
            // chkAnzeigen
            // 
            this.chkAnzeigen.AutoSize = true;
            this.chkAnzeigen.Location = new System.Drawing.Point(172, 237);
            this.chkAnzeigen.Name = "chkAnzeigen";
            this.chkAnzeigen.Size = new System.Drawing.Size(357, 21);
            this.chkAnzeigen.TabIndex = 2;
            this.chkAnzeigen.Text = "Nach der Berechnung den Gesamtbetrag anzeigen ";
            this.chkAnzeigen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zinszahlung pro Jahr";
            // 
            // rBtn2Jahre
            // 
            this.rBtn2Jahre.AutoSize = true;
            this.rBtn2Jahre.Location = new System.Drawing.Point(172, 168);
            this.rBtn2Jahre.Name = "rBtn2Jahre";
            this.rBtn2Jahre.Size = new System.Drawing.Size(409, 21);
            this.rBtn2Jahre.TabIndex = 4;
            this.rBtn2Jahre.TabStop = true;
            this.rBtn2Jahre.Text = "Anlage für 2 Jahre fest (Zinssatz erhöht sich um 0.25% p.a.)";
            this.rBtn2Jahre.UseVisualStyleBackColor = true;
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(431, 435);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabe.TabIndex = 5;
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(431, 67);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 22);
            this.txtEingabe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 532);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.rBtn2Jahre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAnzeigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Name = "Form1";
            this.Text = "Festgeldanlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAnzeigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtn2Jahre;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.TextBox txtEingabe;
    }
}

