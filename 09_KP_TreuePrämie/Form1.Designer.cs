
namespace _09_KP_TreuePrämie
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
            this.txtEingabeJahren = new System.Windows.Forms.TextBox();
            this.txtAusgabePrämie = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeJahren
            // 
            this.txtEingabeJahren.Location = new System.Drawing.Point(479, 112);
            this.txtEingabeJahren.Name = "txtEingabeJahren";
            this.txtEingabeJahren.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeJahren.TabIndex = 0;
            // 
            // txtAusgabePrämie
            // 
            this.txtAusgabePrämie.Location = new System.Drawing.Point(479, 258);
            this.txtAusgabePrämie.Name = "txtAusgabePrämie";
            this.txtAusgabePrämie.ReadOnly = true;
            this.txtAusgabePrämie.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabePrämie.TabIndex = 1;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(312, 175);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(159, 43);
            this.btnBerechnen.TabIndex = 2;
            this.btnBerechnen.Text = "Prämie berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dauer der Beschäftigung in ganze Jahren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sie erhalten eine Prämie in Höhe von:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabePrämie);
            this.Controls.Add(this.txtEingabeJahren);
            this.Name = "Form1";
            this.Text = "Treueprämie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeJahren;
        private System.Windows.Forms.TextBox txtAusgabePrämie;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

