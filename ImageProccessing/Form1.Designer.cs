namespace ImageProccessing
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnSCreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBox.Location = new System.Drawing.Point(0, 91);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(1311, 622);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // btnSCreen
            // 
            this.btnSCreen.Location = new System.Drawing.Point(879, 12);
            this.btnSCreen.Name = "btnSCreen";
            this.btnSCreen.Size = new System.Drawing.Size(227, 30);
            this.btnSCreen.TabIndex = 1;
            this.btnSCreen.Text = "Cuptre";
            this.btnSCreen.UseVisualStyleBackColor = true;
            this.btnSCreen.Click += new System.EventHandler(this.btnSCreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 713);
            this.Controls.Add(this.btnSCreen);
            this.Controls.Add(this.pBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnSCreen;
    }
}

