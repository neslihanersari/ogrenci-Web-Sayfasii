namespace VeriTabaniOdev5.Forms
{
    partial class Ders
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.DersAdlabel1 = new System.Windows.Forms.Label();
            this.DersAdrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Eklebutton1 = new System.Windows.Forms.Button();
            this.Silbutton2 = new System.Windows.Forms.Button();
            this.Guncellebutton3 = new System.Windows.Forms.Button();
            this.DerslerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DersAdlabel1
            // 
            this.DersAdlabel1.AutoSize = true;
            this.DersAdlabel1.Location = new System.Drawing.Point(223, 123);
            this.DersAdlabel1.Name = "DersAdlabel1";
            this.DersAdlabel1.Size = new System.Drawing.Size(59, 16);
            this.DersAdlabel1.TabIndex = 0;
            this.DersAdlabel1.Text = "Ders Adı";
            // 
            // DersAdrichTextBox1
            // 
            this.DersAdrichTextBox1.Location = new System.Drawing.Point(356, 120);
            this.DersAdrichTextBox1.Name = "DersAdrichTextBox1";
            this.DersAdrichTextBox1.Size = new System.Drawing.Size(144, 32);
            this.DersAdrichTextBox1.TabIndex = 1;
            this.DersAdrichTextBox1.Text = "";
            this.DersAdrichTextBox1.TextChanged += new System.EventHandler(this.DersAdrichTextBox1_TextChanged);
            // 
            // Eklebutton1
            // 
            this.Eklebutton1.Location = new System.Drawing.Point(311, 218);
            this.Eklebutton1.Name = "Eklebutton1";
            this.Eklebutton1.Size = new System.Drawing.Size(75, 23);
            this.Eklebutton1.TabIndex = 2;
            this.Eklebutton1.Text = "Ekle";
            this.Eklebutton1.UseVisualStyleBackColor = true;
            this.Eklebutton1.Click += new System.EventHandler(this.Eklebutton1_Click);
            // 
            // Silbutton2
            // 
            this.Silbutton2.Location = new System.Drawing.Point(437, 218);
            this.Silbutton2.Name = "Silbutton2";
            this.Silbutton2.Size = new System.Drawing.Size(75, 23);
            this.Silbutton2.TabIndex = 3;
            this.Silbutton2.Text = "Sil";
            this.Silbutton2.UseVisualStyleBackColor = true;
            this.Silbutton2.Click += new System.EventHandler(this.Silbutton2_Click);
            // 
            // Guncellebutton3
            // 
            this.Guncellebutton3.Location = new System.Drawing.Point(561, 218);
            this.Guncellebutton3.Name = "Guncellebutton3";
            this.Guncellebutton3.Size = new System.Drawing.Size(75, 23);
            this.Guncellebutton3.TabIndex = 4;
            this.Guncellebutton3.Text = "Güncelle";
            this.Guncellebutton3.UseVisualStyleBackColor = true;
            this.Guncellebutton3.Click += new System.EventHandler(this.Guncellebutton3_Click);
            // 
            // DerslerListBox
            // 
            this.DerslerListBox.FormattingEnabled = true;
            this.DerslerListBox.ItemHeight = 16;
            this.DerslerListBox.Location = new System.Drawing.Point(356, 159);
            this.DerslerListBox.Name = "DerslerListBox";
            this.DerslerListBox.Size = new System.Drawing.Size(280, 52);
            this.DerslerListBox.TabIndex = 5;
            this.DerslerListBox.SelectedIndexChanged += new System.EventHandler(this.DerslerListBox_SelectedIndexChanged);
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DerslerListBox);
            this.Controls.Add(this.Guncellebutton3);
            this.Controls.Add(this.Silbutton2);
            this.Controls.Add(this.Eklebutton1);
            this.Controls.Add(this.DersAdrichTextBox1);
            this.Controls.Add(this.DersAdlabel1);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DersAdlabel1;
        private System.Windows.Forms.RichTextBox DersAdrichTextBox1;
        private System.Windows.Forms.Button Eklebutton1;
        private System.Windows.Forms.Button Silbutton2;
        private System.Windows.Forms.Button Guncellebutton3;
        private System.Windows.Forms.ListBox DerslerListBox;
    }
}
