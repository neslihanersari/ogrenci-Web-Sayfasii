namespace VeriTabaniOdev5.Forms
{
    partial class Ogrenci
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxAd;
        private System.Windows.Forms.RichTextBox richTextBoxSoyad;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label OgrenciAdlabel1;
        private System.Windows.Forms.Label OgrenciSoyadlabel2;
        private System.Windows.Forms.Label BolumSecIDlabel3;
        private System.Windows.Forms.ListBox listBoxOgrenciler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBoxAd = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSoyad = new System.Windows.Forms.RichTextBox();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.OgrenciAdlabel1 = new System.Windows.Forms.Label();
            this.OgrenciSoyadlabel2 = new System.Windows.Forms.Label();
            this.BolumSecIDlabel3 = new System.Windows.Forms.Label();
            this.listBoxOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBoxAd
            // 
            this.richTextBoxAd.Location = new System.Drawing.Point(264, 50);
            this.richTextBoxAd.Name = "richTextBoxAd";
            this.richTextBoxAd.Size = new System.Drawing.Size(200, 30);
            this.richTextBoxAd.TabIndex = 0;
            this.richTextBoxAd.Text = "";
            // 
            // richTextBoxSoyad
            // 
            this.richTextBoxSoyad.Location = new System.Drawing.Point(264, 110);
            this.richTextBoxSoyad.Name = "richTextBoxSoyad";
            this.richTextBoxSoyad.Size = new System.Drawing.Size(200, 30);
            this.richTextBoxSoyad.TabIndex = 1;
            this.richTextBoxSoyad.Text = "";
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(264, 160);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBolum.TabIndex = 2;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(264, 216);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(200, 30);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(264, 252);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(200, 30);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(264, 288);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(200, 30);
            this.buttonGuncelle.TabIndex = 5;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // OgrenciAdlabel1
            // 
            this.OgrenciAdlabel1.AutoSize = true;
            this.OgrenciAdlabel1.Location = new System.Drawing.Point(99, 50);
            this.OgrenciAdlabel1.Name = "OgrenciAdlabel1";
            this.OgrenciAdlabel1.Size = new System.Drawing.Size(74, 16);
            this.OgrenciAdlabel1.TabIndex = 6;
            this.OgrenciAdlabel1.Text = "Öğrenci Ad";
            // 
            // OgrenciSoyadlabel2
            // 
            this.OgrenciSoyadlabel2.AutoSize = true;
            this.OgrenciSoyadlabel2.Location = new System.Drawing.Point(99, 110);
            this.OgrenciSoyadlabel2.Name = "OgrenciSoyadlabel2";
            this.OgrenciSoyadlabel2.Size = new System.Drawing.Size(97, 16);
            this.OgrenciSoyadlabel2.TabIndex = 7;
            this.OgrenciSoyadlabel2.Text = "Öğrenci Soyad";
            // 
            // BolumSecIDlabel3
            // 
            this.BolumSecIDlabel3.AutoSize = true;
            this.BolumSecIDlabel3.Location = new System.Drawing.Point(99, 168);
            this.BolumSecIDlabel3.Name = "BolumSecIDlabel3";
            this.BolumSecIDlabel3.Size = new System.Drawing.Size(72, 16);
            this.BolumSecIDlabel3.TabIndex = 8;
            this.BolumSecIDlabel3.Text = "Bölüm Seç";
            // 
            // listBoxOgrenciler
            // 
            this.listBoxOgrenciler.FormattingEnabled = true;
            this.listBoxOgrenciler.ItemHeight = 16;
            this.listBoxOgrenciler.Location = new System.Drawing.Point(500, 50);
            this.listBoxOgrenciler.Name = "listBoxOgrenciler";
            this.listBoxOgrenciler.Size = new System.Drawing.Size(200, 260);
            this.listBoxOgrenciler.TabIndex = 9;
            this.listBoxOgrenciler.SelectedIndexChanged += new System.EventHandler(this.listBoxOgrenciler_SelectedIndexChanged);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOgrenciler);
            this.Controls.Add(this.BolumSecIDlabel3);
            this.Controls.Add(this.OgrenciSoyadlabel2);
            this.Controls.Add(this.OgrenciAdlabel1);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.richTextBoxSoyad);
            this.Controls.Add(this.richTextBoxAd);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
