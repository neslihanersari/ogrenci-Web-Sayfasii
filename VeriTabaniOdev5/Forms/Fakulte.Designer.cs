namespace VeriTabaniOdev5.Forms
{
    partial class Fakulte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FakulteAd = new System.Windows.Forms.Label();
            this.FakulteAdrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FakulteAd
            // 
            this.FakulteAd.AutoSize = true;
            this.FakulteAd.Location = new System.Drawing.Point(246, 111);
            this.FakulteAd.Name = "FakulteAd";
            this.FakulteAd.Size = new System.Drawing.Size(71, 16);
            this.FakulteAd.TabIndex = 0;
            this.FakulteAd.Text = "Fakulte Ad";
            this.FakulteAd.Click += new System.EventHandler(this.FakulteAd_Click);
            // 
            // FakulteAdrichTextBox1
            // 
            this.FakulteAdrichTextBox1.Location = new System.Drawing.Point(376, 108);
            this.FakulteAdrichTextBox1.Name = "FakulteAdrichTextBox1";
            this.FakulteAdrichTextBox1.Size = new System.Drawing.Size(152, 30);
            this.FakulteAdrichTextBox1.TabIndex = 1;
            this.FakulteAdrichTextBox1.Text = "";
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(391, 171);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 23);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Fakulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.FakulteAdrichTextBox1);
            this.Controls.Add(this.FakulteAd);
            this.Name = "Fakulte";
            this.Text = "Fakulte";
            this.Load += new System.EventHandler(this.Fakulte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FakulteAd;
        private System.Windows.Forms.RichTextBox FakulteAdrichTextBox1;
        private System.Windows.Forms.Button Ekle;
    }
}