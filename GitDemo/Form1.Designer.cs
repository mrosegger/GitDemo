namespace GitDemo
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(12, 12);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(108, 99);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(164, 12);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(108, 99);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(12, 150);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(108, 99);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(164, 150);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(108, 99);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Git is nice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
    }
}

