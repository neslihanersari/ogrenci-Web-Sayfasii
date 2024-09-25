using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class Ogrenci : Form
    {
        private AppDbContext _context;
        private model.Ogrenci selectedOgrenci;

        public Ogrenci()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            LoadBolumler();
            LoadOgrenciler();
        }

        private void LoadBolumler()
        {
            var bolumler = _context.Bolumler.ToList();
            comboBoxBolum.DataSource = bolumler;
            comboBoxBolum.DisplayMember = "BolumAd";
            comboBoxBolum.ValueMember = "BolumId";
        }

        private void LoadOgrenciler()
        {
            var ogrenciler = _context.Ogrenciler.ToList();
            listBoxOgrenciler.DataSource = ogrenciler;
            listBoxOgrenciler.DisplayMember = "Ad";
            listBoxOgrenciler.ValueMember = "OgrenciId";
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem != null)
            {
                selectedOgrenci = (model.Ogrenci)listBoxOgrenciler.SelectedItem;
                richTextBoxAd.Text = selectedOgrenci.Ad;
                richTextBoxSoyad.Text = selectedOgrenci.Soyad;
                comboBoxBolum.SelectedValue = selectedOgrenci.BolumId;
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            var yeniOgrenci = new model.Ogrenci
            {
                Ad = richTextBoxAd.Text,
                Soyad = richTextBoxSoyad.Text,
                BolumId = (int)comboBoxBolum.SelectedValue
            };

            _context.Ogrenciler.Add(yeniOgrenci);
            _context.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla eklendi.");
            LoadOgrenciler();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (selectedOgrenci != null)
            {
                _context.Ogrenciler.Remove(selectedOgrenci);
                _context.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla silindi.");
                LoadOgrenciler();
            }
            else
            {
                MessageBox.Show("Öncelikle bir öğrenci seçiniz.");
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedOgrenci != null)
            {
                selectedOgrenci.Ad = richTextBoxAd.Text;
                selectedOgrenci.Soyad = richTextBoxSoyad.Text;
                selectedOgrenci.BolumId = (int)comboBoxBolum.SelectedValue;

                _context.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla güncellendi.");
                LoadOgrenciler();
            }
            else
            {
                MessageBox.Show("Öncelikle bir öğrenci seçiniz.");
            }
        }
    }
}

