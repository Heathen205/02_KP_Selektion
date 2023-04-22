
namespace _01_KP_Prämie
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
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtEingabeUmsatz = new System.Windows.Forms.TextBox();
            this.txtAusgabePrämie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jahresumsatz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prämie";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(163, 95);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(107, 42);
            this.btnBerechnen.TabIndex = 2;
            this.btnBerechnen.Text = "Prämie berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // txtEingabeUmsatz
            // 
            this.txtEingabeUmsatz.Location = new System.Drawing.Point(289, 30);
            this.txtEingabeUmsatz.Name = "txtEingabeUmsatz";
            this.txtEingabeUmsatz.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeUmsatz.TabIndex = 3;
            // 
            // txtAusgabePrämie
            // 
            this.txtAusgabePrämie.Location = new System.Drawing.Point(289, 167);
            this.txtAusgabePrämie.Name = "txtAusgabePrämie";
            this.txtAusgabePrämie.ReadOnly = true;
            this.txtAusgabePrämie.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabePrämie.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabePrämie);
            this.Controls.Add(this.txtEingabeUmsatz);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prämie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox txtEingabeUmsatz;
        private System.Windows.Forms.TextBox txtAusgabePrämie;
    }
}

