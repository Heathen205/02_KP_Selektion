
namespace _06_KP_RadiButtonCheckBoxen
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
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkCPlus = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.btnAbsenden = new System.Windows.Forms.Button();
            this.rBtnMann = new System.Windows.Forms.RadioButton();
            this.rBtnWeib = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(442, 115);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(130, 21);
            this.chkCsharp.TabIndex = 0;
            this.chkCsharp.Text = "C# - Kenntnisse";
            this.chkCsharp.UseVisualStyleBackColor = true;
            // 
            // chkCPlus
            // 
            this.chkCPlus.AutoSize = true;
            this.chkCPlus.Location = new System.Drawing.Point(442, 179);
            this.chkCPlus.Name = "chkCPlus";
            this.chkCPlus.Size = new System.Drawing.Size(138, 21);
            this.chkCPlus.TabIndex = 1;
            this.chkCPlus.Text = "C++ - Kenntnisse";
            this.chkCPlus.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(447, 244);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(143, 21);
            this.chkJava.TabIndex = 2;
            this.chkJava.Text = "Java - Kenntnisse";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // btnAbsenden
            // 
            this.btnAbsenden.Location = new System.Drawing.Point(443, 329);
            this.btnAbsenden.Name = "btnAbsenden";
            this.btnAbsenden.Size = new System.Drawing.Size(112, 48);
            this.btnAbsenden.TabIndex = 3;
            this.btnAbsenden.Text = "Absenden";
            this.btnAbsenden.UseVisualStyleBackColor = true;
            this.btnAbsenden.Click += new System.EventHandler(this.btnAbsenden_Click);
            // 
            // rBtnMann
            // 
            this.rBtnMann.AutoSize = true;
            this.rBtnMann.Location = new System.Drawing.Point(149, 138);
            this.rBtnMann.Name = "rBtnMann";
            this.rBtnMann.Size = new System.Drawing.Size(85, 21);
            this.rBtnMann.TabIndex = 4;
            this.rBtnMann.TabStop = true;
            this.rBtnMann.Text = "Männlich";
            this.rBtnMann.UseVisualStyleBackColor = true;
            // 
            // rBtnWeib
            // 
            this.rBtnWeib.AutoSize = true;
            this.rBtnWeib.Location = new System.Drawing.Point(152, 225);
            this.rBtnWeib.Name = "rBtnWeib";
            this.rBtnWeib.Size = new System.Drawing.Size(82, 21);
            this.rBtnWeib.TabIndex = 5;
            this.rBtnWeib.TabStop = true;
            this.rBtnWeib.Text = "Weiblich";
            this.rBtnWeib.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtnWeib);
            this.Controls.Add(this.rBtnMann);
            this.Controls.Add(this.btnAbsenden);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkCPlus);
            this.Controls.Add(this.chkCsharp);
            this.Name = "Form1";
            this.Text = "Radiobuttons und Checkboxen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkCPlus;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.Button btnAbsenden;
        private System.Windows.Forms.RadioButton rBtnMann;
        private System.Windows.Forms.RadioButton rBtnWeib;
    }
}

