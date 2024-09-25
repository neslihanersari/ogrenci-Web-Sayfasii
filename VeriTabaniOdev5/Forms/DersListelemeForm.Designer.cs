namespace VeriTabaniOdev5.Forms
{
    partial class DersListelemeForm
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
            this.OgrenciNoLabel = new System.Windows.Forms.Label();
            this.OgrenciNoTextBox = new System.Windows.Forms.TextBox();
            this.ListeleOgrenciButton = new System.Windows.Forms.Button();
            this.OgrenciDerslerDataGridView = new System.Windows.Forms.DataGridView();
            this.YilLabel = new System.Windows.Forms.Label();
            this.YilTextBox = new System.Windows.Forms.TextBox();
            this.YariYilLabel = new System.Windows.Forms.Label();
            this.YariYilComboBox = new System.Windows.Forms.ComboBox();
            this.ListeleYilButton = new System.Windows.Forms.Button();
            this.DersSecimDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDerslerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersSecimDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciNoLabel
            // 
            this.OgrenciNoLabel.AutoSize = true;
            this.OgrenciNoLabel.Location = new System.Drawing.Point(20, 20);
            this.OgrenciNoLabel.Name = "OgrenciNoLabel";
            this.OgrenciNoLabel.Size = new System.Drawing.Size(78, 16);
            this.OgrenciNoLabel.TabIndex = 0;
            this.OgrenciNoLabel.Text = "Öğrenci No:";
            // 
            // OgrenciNoTextBox
            // 
            this.OgrenciNoTextBox.Location = new System.Drawing.Point(120, 20);
            this.OgrenciNoTextBox.Name = "OgrenciNoTextBox";
            this.OgrenciNoTextBox.Size = new System.Drawing.Size(150, 22);
            this.OgrenciNoTextBox.TabIndex = 1;
            // 
            // ListeleOgrenciButton
            // 
            this.ListeleOgrenciButton.Location = new System.Drawing.Point(280, 20);
            this.ListeleOgrenciButton.Name = "ListeleOgrenciButton";
            this.ListeleOgrenciButton.Size = new System.Drawing.Size(75, 25);
            this.ListeleOgrenciButton.TabIndex = 2;
            this.ListeleOgrenciButton.Text = "Listele";
            this.ListeleOgrenciButton.UseVisualStyleBackColor = true;
            this.ListeleOgrenciButton.Click += new System.EventHandler(this.ListeleOgrenciButton_Click);
            // 
            // OgrenciDerslerDataGridView
            // 
            this.OgrenciDerslerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgrenciDerslerDataGridView.Location = new System.Drawing.Point(20, 60);
            this.OgrenciDerslerDataGridView.Name = "OgrenciDerslerDataGridView";
            this.OgrenciDerslerDataGridView.RowHeadersWidth = 51;
            this.OgrenciDerslerDataGridView.RowTemplate.Height = 24;
            this.OgrenciDerslerDataGridView.Size = new System.Drawing.Size(700, 200);
            this.OgrenciDerslerDataGridView.TabIndex = 3;
            this.OgrenciDerslerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OgrenciDerslerDataGridView_CellContentClick);
            // 
            // YilLabel
            // 
            this.YilLabel.AutoSize = true;
            this.YilLabel.Location = new System.Drawing.Point(20, 280);
            this.YilLabel.Name = "YilLabel";
            this.YilLabel.Size = new System.Drawing.Size(25, 16);
            this.YilLabel.TabIndex = 4;
            this.YilLabel.Text = "Yıl:";
            // 
            // YilTextBox
            // 
            this.YilTextBox.Location = new System.Drawing.Point(120, 280);
            this.YilTextBox.Name = "YilTextBox";
            this.YilTextBox.Size = new System.Drawing.Size(150, 22);
            this.YilTextBox.TabIndex = 5;
            // 
            // YariYilLabel
            // 
            this.YariYilLabel.AutoSize = true;
            this.YariYilLabel.Location = new System.Drawing.Point(20, 320);
            this.YariYilLabel.Name = "YariYilLabel";
            this.YariYilLabel.Size = new System.Drawing.Size(47, 16);
            this.YariYilLabel.TabIndex = 6;
            this.YariYilLabel.Text = "Yarıyıl:";
            // 
            // YariYilComboBox
            // 
            this.YariYilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YariYilComboBox.FormattingEnabled = true;
            this.YariYilComboBox.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.YariYilComboBox.Location = new System.Drawing.Point(120, 320);
            this.YariYilComboBox.Name = "YariYilComboBox";
            this.YariYilComboBox.Size = new System.Drawing.Size(150, 24);
            this.YariYilComboBox.TabIndex = 7;
            // 
            // ListeleYilButton
            // 
            this.ListeleYilButton.Location = new System.Drawing.Point(280, 320);
            this.ListeleYilButton.Name = "ListeleYilButton";
            this.ListeleYilButton.Size = new System.Drawing.Size(75, 25);
            this.ListeleYilButton.TabIndex = 8;
            this.ListeleYilButton.Text = "Listele";
            this.ListeleYilButton.UseVisualStyleBackColor = true;
            this.ListeleYilButton.Click += new System.EventHandler(this.ListeleYilButton_Click);
            // 
            // DersSecimDataGridView
            // 
            this.DersSecimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DersSecimDataGridView.Location = new System.Drawing.Point(20, 360);
            this.DersSecimDataGridView.Name = "DersSecimDataGridView";
            this.DersSecimDataGridView.RowHeadersWidth = 51;
            this.DersSecimDataGridView.RowTemplate.Height = 24;
            this.DersSecimDataGridView.Size = new System.Drawing.Size(700, 200);
            this.DersSecimDataGridView.TabIndex = 9;
            // 
            // DersListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.DersSecimDataGridView);
            this.Controls.Add(this.ListeleYilButton);
            this.Controls.Add(this.YariYilComboBox);
            this.Controls.Add(this.YariYilLabel);
            this.Controls.Add(this.YilTextBox);
            this.Controls.Add(this.YilLabel);
            this.Controls.Add(this.OgrenciDerslerDataGridView);
            this.Controls.Add(this.ListeleOgrenciButton);
            this.Controls.Add(this.OgrenciNoTextBox);
            this.Controls.Add(this.OgrenciNoLabel);
            this.Name = "DersListelemeForm";
            this.Text = "Ders Listeleme";
            this.Load += new System.EventHandler(this.DersListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDerslerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DersSecimDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrenciNoLabel;
        private System.Windows.Forms.TextBox OgrenciNoTextBox;
        private System.Windows.Forms.Button ListeleOgrenciButton;
        private System.Windows.Forms.DataGridView OgrenciDerslerDataGridView;
        private System.Windows.Forms.Label YilLabel;
        private System.Windows.Forms.TextBox YilTextBox;
        private System.Windows.Forms.Label YariYilLabel;
        private System.Windows.Forms.ComboBox YariYilComboBox;
        private System.Windows.Forms.Button ListeleYilButton;
        private System.Windows.Forms.DataGridView DersSecimDataGridView;
    }
}
