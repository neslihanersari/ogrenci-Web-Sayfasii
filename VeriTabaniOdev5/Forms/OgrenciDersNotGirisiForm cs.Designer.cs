namespace VeriTabaniOdev5.Forms
{
    partial class OgrenciDersNotGirisiForm
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
            this.DersLabel = new System.Windows.Forms.Label();
            this.DersComboBox = new System.Windows.Forms.ComboBox();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.OgrenciDersDataGridView = new System.Windows.Forms.DataGridView();
            this.KaydetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DersLabel
            // 
            this.DersLabel.AutoSize = true;
            this.DersLabel.Location = new System.Drawing.Point(23, 28);
            this.DersLabel.Name = "DersLabel";
            this.DersLabel.Size = new System.Drawing.Size(39, 16);
            this.DersLabel.TabIndex = 0;
            this.DersLabel.Text = "Ders:";
            // 
            // DersComboBox
            // 
            this.DersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DersComboBox.FormattingEnabled = true;
            this.DersComboBox.Location = new System.Drawing.Point(68, 25);
            this.DersComboBox.Name = "DersComboBox";
            this.DersComboBox.Size = new System.Drawing.Size(200, 24);
            this.DersComboBox.TabIndex = 1;
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(274, 24);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(75, 25);
            this.ListeleButton.TabIndex = 2;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.ListeleButton_Click);
            // 
            // OgrenciDersDataGridView
            // 
            this.OgrenciDersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgrenciDersDataGridView.Location = new System.Drawing.Point(26, 65);
            this.OgrenciDersDataGridView.Name = "OgrenciDersDataGridView";
            this.OgrenciDersDataGridView.RowHeadersWidth = 51;
            this.OgrenciDersDataGridView.RowTemplate.Height = 24;
            this.OgrenciDersDataGridView.Size = new System.Drawing.Size(600, 300);
            this.OgrenciDersDataGridView.TabIndex = 3;
            this.OgrenciDersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OgrenciDersDataGridView_CellContentClick);
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(551, 380);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(75, 23);
            this.KaydetButton.TabIndex = 4;
            this.KaydetButton.Text = "Kaydet";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // OgrenciDersNotGirisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.OgrenciDersDataGridView);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.DersComboBox);
            this.Controls.Add(this.DersLabel);
            this.Name = "OgrenciDersNotGirisiForm";
            this.Text = "Öğrenci Ders Not Girişi";
            this.Load += new System.EventHandler(this.OgrenciDersNotGirisiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DersLabel;
        private System.Windows.Forms.ComboBox DersComboBox;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.DataGridView OgrenciDersDataGridView;
        private System.Windows.Forms.Button KaydetButton;
    }
}
