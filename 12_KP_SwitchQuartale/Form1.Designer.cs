
namespace _12_KP_SwitchQuartale
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
            this.btnAnzeigen1 = new System.Windows.Forms.Button();
            this.btnAnzeigen2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonat = new System.Windows.Forms.ComboBox();
            this.txtEingabeMonat = new System.Windows.Forms.TextBox();
            this.txtAusgabe1 = new System.Windows.Forms.TextBox();
            this.txtAusgabe2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnzeigen1
            // 
            this.btnAnzeigen1.Location = new System.Drawing.Point(381, 139);
            this.btnAnzeigen1.Name = "btnAnzeigen1";
            this.btnAnzeigen1.Size = new System.Drawing.Size(134, 57);
            this.btnAnzeigen1.TabIndex = 0;
            this.btnAnzeigen1.Text = "Quartal anzeigen";
            this.btnAnzeigen1.UseVisualStyleBackColor = true;
            this.btnAnzeigen1.Click += new System.EventHandler(this.btnAnzeigen1_Click);
            // 
            // btnAnzeigen2
            // 
            this.btnAnzeigen2.Location = new System.Drawing.Point(381, 280);
            this.btnAnzeigen2.Name = "btnAnzeigen2";
            this.btnAnzeigen2.Size = new System.Drawing.Size(134, 57);
            this.btnAnzeigen2.TabIndex = 1;
            this.btnAnzeigen2.Text = "Quartal anzeigen";
            this.btnAnzeigen2.UseVisualStyleBackColor = true;
            this.btnAnzeigen2.Click += new System.EventHandler(this.btnAnzeigen2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geben Sie einen Monat ein:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wählen Sie einen Monat aus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nummer 1";
            // 
            // cmbMonat
            // 
            this.cmbMonat.FormattingEnabled = true;
            this.cmbMonat.Location = new System.Drawing.Point(222, 303);
            this.cmbMonat.Name = "cmbMonat";
            this.cmbMonat.Size = new System.Drawing.Size(133, 24);
            this.cmbMonat.TabIndex = 5;
            // 
            // txtEingabeMonat
            // 
            this.txtEingabeMonat.Location = new System.Drawing.Point(225, 163);
            this.txtEingabeMonat.Name = "txtEingabeMonat";
            this.txtEingabeMonat.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeMonat.TabIndex = 6;
            // 
            // txtAusgabe1
            // 
            this.txtAusgabe1.Location = new System.Drawing.Point(607, 163);
            this.txtAusgabe1.Name = "txtAusgabe1";
            this.txtAusgabe1.ReadOnly = true;
            this.txtAusgabe1.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabe1.TabIndex = 7;
            // 
            // txtAusgabe2
            // 
            this.txtAusgabe2.Location = new System.Drawing.Point(607, 305);
            this.txtAusgabe2.Name = "txtAusgabe2";
            this.txtAusgabe2.ReadOnly = true;
            this.txtAusgabe2.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabe2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nummer 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAusgabe2);
            this.Controls.Add(this.txtAusgabe1);
            this.Controls.Add(this.txtEingabeMonat);
            this.Controls.Add(this.cmbMonat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnzeigen2);
            this.Controls.Add(this.btnAnzeigen1);
            this.Name = "Form1";
            this.Text = "Monat - Quartal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnzeigen1;
        private System.Windows.Forms.Button btnAnzeigen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonat;
        private System.Windows.Forms.TextBox txtEingabeMonat;
        private System.Windows.Forms.TextBox txtAusgabe1;
        private System.Windows.Forms.TextBox txtAusgabe2;
        private System.Windows.Forms.Label label4;
    }
}

