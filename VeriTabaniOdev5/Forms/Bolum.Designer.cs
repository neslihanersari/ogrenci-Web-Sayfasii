namespace VeriTabaniOdev5.Forms
{
    partial class Bolum
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox bolumAdTextBox;
        private System.Windows.Forms.ComboBox fakulteComboBox;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label BolumAdLabel;
        private System.Windows.Forms.Label Fakultesec;
        private System.Windows.Forms.ListBox listBoxBolumler;

        private void InitializeComponent()
        {
            this.bolumAdTextBox = new System.Windows.Forms.TextBox();
            this.fakulteComboBox = new System.Windows.Forms.ComboBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.listBoxBolumler = new System.Windows.Forms.ListBox();
            this.BolumAdLabel = new System.Windows.Forms.Label();
            this.Fakultesec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bolumAdTextBox
            // 
            this.bolumAdTextBox.Location = new System.Drawing.Point(256, 53);
            this.bolumAdTextBox.Name = "bolumAdTextBox";
            this.bolumAdTextBox.Size = new System.Drawing.Size(260, 22);
            this.bolumAdTextBox.TabIndex = 0;
            this.bolumAdTextBox.TextChanged += new System.EventHandler(this.BolumAdrichTextBox1_TextChanged);
            // 
            // fakulteComboBox
            // 
            this.fakulteComboBox.FormattingEnabled = true;
            this.fakulteComboBox.Location = new System.Drawing.Point(256, 111);
            this.fakulteComboBox.Name = "fakulteComboBox";
            this.fakulteComboBox.Size = new System.Drawing.Size(260, 24);
            this.fakulteComboBox.TabIndex = 1;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(97, 174);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(75, 23);
            this.ekleButton.TabIndex = 2;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(257, 174);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 3;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.Sil_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(414, 174);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(102, 23);
            this.guncelleButton.TabIndex = 4;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // listBoxBolumler
            // 
            this.listBoxBolumler.FormattingEnabled = true;
            this.listBoxBolumler.ItemHeight = 16;
            this.listBoxBolumler.Location = new System.Drawing.Point(97, 242);
            this.listBoxBolumler.Name = "listBoxBolumler";
            this.listBoxBolumler.Size = new System.Drawing.Size(419, 196);
            this.listBoxBolumler.TabIndex = 5;
            this.listBoxBolumler.SelectedIndexChanged += new System.EventHandler(this.listBoxBolumler_SelectedIndexChanged);
            // 
            // BolumAdLabel
            // 
            this.BolumAdLabel.AutoSize = true;
            this.BolumAdLabel.Location = new System.Drawing.Point(133, 53);
            this.BolumAdLabel.Name = "BolumAdLabel";
            this.BolumAdLabel.Size = new System.Drawing.Size(62, 17);
            this.BolumAdLabel.TabIndex = 6;
            this.BolumAdLabel.Text = "BolumAd";
            // 
            // Fakultesec
            // 
            this.Fakultesec.AutoSize = true;
            this.Fakultesec.Location = new System.Drawing.Point(133, 111);
            this.Fakultesec.Name = "Fakultesec";
            this.Fakultesec.Size = new System.Drawing.Size(76, 17);
            this.Fakultesec.TabIndex = 7;
            this.Fakultesec.Text = "Fakulte sec";
            // 
            // Bolum
            // 
            this.ClientSize = new System.Drawing.Size(718, 491);
            this.Controls.Add(this.Fakultesec);
            this.Controls.Add(this.BolumAdLabel);
            this.Controls.Add(this.listBoxBolumler);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.fakulteComboBox);
            this.Controls.Add(this.bolumAdTextBox);
            this.Name = "Bolum";
            this.Load += new System.EventHandler(this.Bolum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
