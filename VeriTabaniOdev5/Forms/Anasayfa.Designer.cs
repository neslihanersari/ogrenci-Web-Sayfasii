namespace VeriTabaniOdev5.Forms
{
    partial class Anasayfa
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
            this.FakulteEkle = new System.Windows.Forms.Button();
            this.BolumEkle = new System.Windows.Forms.Button();
            this.OgrenciEkle = new System.Windows.Forms.Button();
            this.OgrenciSorgula = new System.Windows.Forms.Button();
            this.OgrenciSorgulaWeb = new System.Windows.Forms.Button();
            this.DersEkle = new System.Windows.Forms.Button();
            this.ListelemeEkranıbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FakulteEkle
            // 
            this.FakulteEkle.Location = new System.Drawing.Point(335, 62);
            this.FakulteEkle.Name = "FakulteEkle";
            this.FakulteEkle.Size = new System.Drawing.Size(138, 42);
            this.FakulteEkle.TabIndex = 0;
            this.FakulteEkle.Text = "Fakulte Ekle";
            this.FakulteEkle.UseVisualStyleBackColor = true;
            this.FakulteEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // BolumEkle
            // 
            this.BolumEkle.Location = new System.Drawing.Point(335, 123);
            this.BolumEkle.Name = "BolumEkle";
            this.BolumEkle.Size = new System.Drawing.Size(138, 44);
            this.BolumEkle.TabIndex = 1;
            this.BolumEkle.Text = "Bolum Ekle";
            this.BolumEkle.UseVisualStyleBackColor = true;
            this.BolumEkle.Click += new System.EventHandler(this.BolumEkle_Click);
            // 
            // OgrenciEkle
            // 
            this.OgrenciEkle.Location = new System.Drawing.Point(335, 189);
            this.OgrenciEkle.Name = "OgrenciEkle";
            this.OgrenciEkle.Size = new System.Drawing.Size(138, 48);
            this.OgrenciEkle.TabIndex = 2;
            this.OgrenciEkle.Text = "Ogrenci Ekle";
            this.OgrenciEkle.UseVisualStyleBackColor = true;
            this.OgrenciEkle.Click += new System.EventHandler(this.OgrenciEkle_Click);
            // 
            // OgrenciSorgula
            // 
            this.OgrenciSorgula.Location = new System.Drawing.Point(335, 243);
            this.OgrenciSorgula.Name = "OgrenciSorgula";
            this.OgrenciSorgula.Size = new System.Drawing.Size(138, 44);
            this.OgrenciSorgula.TabIndex = 3;
            this.OgrenciSorgula.Text = "Ogrenci Sorgula";
            this.OgrenciSorgula.UseVisualStyleBackColor = true;
            this.OgrenciSorgula.Click += new System.EventHandler(this.OgrenciSorgula_Click);
            // 
            // OgrenciSorgulaWeb
            // 
            this.OgrenciSorgulaWeb.Location = new System.Drawing.Point(335, 306);
            this.OgrenciSorgulaWeb.Name = "OgrenciSorgulaWeb";
            this.OgrenciSorgulaWeb.Size = new System.Drawing.Size(138, 45);
            this.OgrenciSorgulaWeb.TabIndex = 4;
            this.OgrenciSorgulaWeb.Text = "Ogrenci Ders Not Girisi";
            this.OgrenciSorgulaWeb.UseVisualStyleBackColor = true;
            this.OgrenciSorgulaWeb.Click += new System.EventHandler(this.OgrenciSorgulaWeb_Click);
            // 
            // DersEkle
            // 
            this.DersEkle.Location = new System.Drawing.Point(335, 367);
            this.DersEkle.Name = "DersEkle";
            this.DersEkle.Size = new System.Drawing.Size(138, 45);
            this.DersEkle.TabIndex = 5;
            this.DersEkle.Text = "Ders Ekle";
            this.DersEkle.UseVisualStyleBackColor = true;
            this.DersEkle.Click += new System.EventHandler(this.DersEkle_Click);
            // 
            // ListelemeEkranıbutton1
            // 
            this.ListelemeEkranıbutton1.Location = new System.Drawing.Point(335, 433);
            this.ListelemeEkranıbutton1.Name = "ListelemeEkranıbutton1";
            this.ListelemeEkranıbutton1.Size = new System.Drawing.Size(145, 44);
            this.ListelemeEkranıbutton1.TabIndex = 6;
            this.ListelemeEkranıbutton1.Text = "Listeleme Ekranı";
            this.ListelemeEkranıbutton1.UseVisualStyleBackColor = true;
            this.ListelemeEkranıbutton1.Click += new System.EventHandler(this.ListelemeEkranıbutton1_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 565);
            this.Controls.Add(this.ListelemeEkranıbutton1);
            this.Controls.Add(this.DersEkle);
            this.Controls.Add(this.OgrenciSorgulaWeb);
            this.Controls.Add(this.OgrenciSorgula);
            this.Controls.Add(this.OgrenciEkle);
            this.Controls.Add(this.BolumEkle);
            this.Controls.Add(this.FakulteEkle);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FakulteEkle;
        private System.Windows.Forms.Button BolumEkle;
        private System.Windows.Forms.Button OgrenciEkle;
        private System.Windows.Forms.Button OgrenciSorgula;
        private System.Windows.Forms.Button OgrenciSorgulaWeb;
        private System.Windows.Forms.Button DersEkle;
        private System.Windows.Forms.Button ListelemeEkranıbutton1;
    }
}