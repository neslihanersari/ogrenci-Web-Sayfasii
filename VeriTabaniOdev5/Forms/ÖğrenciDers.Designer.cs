namespace VeriTabaniOdev5.Forms
{
    partial class OgrenciDersForm
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
            this.OgrenciLabel = new System.Windows.Forms.Label();
            this.DersLabel = new System.Windows.Forms.Label();
            this.YilLabel = new System.Windows.Forms.Label();
            this.YariYilLabel = new System.Windows.Forms.Label();
            this.OgrenciComboBox = new System.Windows.Forms.ComboBox();
            this.DersComboBox = new System.Windows.Forms.ComboBox();
            this.YilNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YariYilNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EkleButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.OgrenciDersListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.YilNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YariYilNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciLabel
            // 
            this.OgrenciLabel.AutoSize = true;
            this.OgrenciLabel.Location = new System.Drawing.Point(23, 28);
            this.OgrenciLabel.Name = "OgrenciLabel";
            this.OgrenciLabel.Size = new System.Drawing.Size(58, 16);
            this.OgrenciLabel.TabIndex = 0;
            this.OgrenciLabel.Text = "Öğrenci:";
            // 
            // DersLabel
            // 
            this.DersLabel.AutoSize = true;
            this.DersLabel.Location = new System.Drawing.Point(23, 66);
            this.DersLabel.Name = "DersLabel";
            this.DersLabel.Size = new System.Drawing.Size(39, 16);
            this.DersLabel.TabIndex = 1;
            this.DersLabel.Text = "Ders:";
            // 
            // YilLabel
            // 
            this.YilLabel.AutoSize = true;
            this.YilLabel.Location = new System.Drawing.Point(23, 104);
            this.YilLabel.Name = "YilLabel";
            this.YilLabel.Size = new System.Drawing.Size(24, 16);
            this.YilLabel.TabIndex = 2;
            this.YilLabel.Text = "Yıl:";
            // 
            // YariYilLabel
            // 
            this.YariYilLabel.AutoSize = true;
            this.YariYilLabel.Location = new System.Drawing.Point(23, 142);
            this.YariYilLabel.Name = "YariYilLabel";
            this.YariYilLabel.Size = new System.Drawing.Size(51, 16);
            this.YariYilLabel.TabIndex = 3;
            this.YariYilLabel.Text = "Yarı Yıl:";
            // 
            // OgrenciComboBox
            // 
            this.OgrenciComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OgrenciComboBox.FormattingEnabled = true;
            this.OgrenciComboBox.Location = new System.Drawing.Point(87, 25);
            this.OgrenciComboBox.Name = "OgrenciComboBox";
            this.OgrenciComboBox.Size = new System.Drawing.Size(200, 24);
            this.OgrenciComboBox.TabIndex = 4;
            // 
            // DersComboBox
            // 
            this.DersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DersComboBox.FormattingEnabled = true;
            this.DersComboBox.Location = new System.Drawing.Point(87, 63);
            this.DersComboBox.Name = "DersComboBox";
            this.DersComboBox.Size = new System.Drawing.Size(200, 24);
            this.DersComboBox.TabIndex = 5;
            // 
            // YilNumericUpDown
            // 
            this.YilNumericUpDown.Location = new System.Drawing.Point(87, 102);
            this.YilNumericUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.YilNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YilNumericUpDown.Name = "YilNumericUpDown";
            this.YilNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.YilNumericUpDown.TabIndex = 6;
            this.YilNumericUpDown.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // YariYilNumericUpDown
            // 
            this.YariYilNumericUpDown.Location = new System.Drawing.Point(87, 140);
            this.YariYilNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.YariYilNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YariYilNumericUpDown.Name = "YariYilNumericUpDown";
            this.YariYilNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.YariYilNumericUpDown.TabIndex = 7;
            this.YariYilNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EkleButton
            // 
            this.EkleButton.Location = new System.Drawing.Point(87, 179);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(75, 23);
            this.EkleButton.TabIndex = 8;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(212, 179);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(75, 23);
            this.SilButton.TabIndex = 9;
            this.SilButton.Text = "Sil";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.Location = new System.Drawing.Point(337, 179);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(75, 23);
            this.GuncelleButton.TabIndex = 10;
            this.GuncelleButton.Text = "Güncelle";
            this.GuncelleButton.UseVisualStyleBackColor = true;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // OgrenciDersListBox
            // 
            this.OgrenciDersListBox.FormattingEnabled = true;
            this.OgrenciDersListBox.ItemHeight = 16;
            this.OgrenciDersListBox.Location = new System.Drawing.Point(26, 225);
            this.OgrenciDersListBox.Name = "OgrenciDersListBox";
            this.OgrenciDersListBox.Size = new System.Drawing.Size(386, 164);
            this.OgrenciDersListBox.TabIndex = 11;
            this.OgrenciDersListBox.SelectedIndexChanged += new System.EventHandler(this.OgrenciDersListBox_SelectedIndexChanged);
            // 
            // OgrenciDersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OgrenciDersListBox);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.YariYilNumericUpDown);
            this.Controls.Add(this.YilNumericUpDown);
            this.Controls.Add(this.DersComboBox);
            this.Controls.Add(this.OgrenciComboBox);
            this.Controls.Add(this.YariYilLabel);
            this.Controls.Add(this.YilLabel);
            this.Controls.Add(this.DersLabel);
            this.Controls.Add(this.OgrenciLabel);
            this.Name = "OgrenciDersForm";
            this.Text = "Öğrenci Ders Atama";
            this.Load += new System.EventHandler(this.OgrenciDersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YilNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YariYilNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrenciLabel;
        private System.Windows.Forms.Label DersLabel;
        private System.Windows.Forms.Label YilLabel;
        private System.Windows.Forms.Label YariYilLabel;
        private System.Windows.Forms.ComboBox OgrenciComboBox;
        private System.Windows.Forms.ComboBox DersComboBox;
        private System.Windows.Forms.NumericUpDown YilNumericUpDown;
        private System.Windows.Forms.NumericUpDown YariYilNumericUpDown;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button GuncelleButton;
        private System.Windows.Forms.ListBox OgrenciDersListBox;
    }
}
