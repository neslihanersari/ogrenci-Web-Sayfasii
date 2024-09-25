using System;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class Bolum : Form
    {
        private AppDbContext _context;
        private model.Bolum selectedBolum;

        public Bolum()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            LoadFakulteler();
            LoadBolumler();
        }

        private void LoadFakulteler()
        {
            var fakulteler = _context.Fakulteler.ToList();
            fakulteComboBox.DataSource = fakulteler;
            fakulteComboBox.DisplayMember = "FakulteAd";
            fakulteComboBox.ValueMember = "FakulteId";
        }

        private void LoadBolumler()
        {
            var bolumler = _context.Bolumler.ToList();
            listBoxBolumler.DataSource = bolumler;
            listBoxBolumler.DisplayMember = "BolumAd";
            listBoxBolumler.ValueMember = "BolumId";
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string bolumAd = bolumAdTextBox.Text;
            int fakulteId = (int)fakulteComboBox.SelectedValue;

            if (!string.IsNullOrEmpty(bolumAd) && fakulteId > 0)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var bolum = new model.Bolum { BolumAd = bolumAd, FakulteId = fakulteId };
                        context.Bolumler.Add(bolum);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Bölüm başarıyla eklendi.");
                    LoadBolumler(); // Bölümleri yeniden yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bölüm eklenirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (selectedBolum != null)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var bolum = context.Bolumler.FirstOrDefault(b => b.BolumId == selectedBolum.BolumId);
                        if (bolum != null)
                        {
                            context.Bolumler.Remove(bolum);
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Bölüm başarıyla silindi.");
                    LoadBolumler(); // Bölümleri yeniden yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bölüm silinirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bölüm seçin.");
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (selectedBolum != null)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var bolum = context.Bolumler.FirstOrDefault(b => b.BolumId == selectedBolum.BolumId);
                        if (bolum != null)
                        {
                            bolum.BolumAd = bolumAdTextBox.Text;
                            bolum.FakulteId = (int)fakulteComboBox.SelectedValue;
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Bölüm başarıyla güncellendi.");
                    LoadBolumler(); // Bölümleri yeniden yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bölüm güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bölüm seçin.");
            }
        }

        private void BolumAdrichTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Boş bırakıldı, gerekirse doldurabilirsiniz.
        }

        private void listBoxBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBolumler.SelectedItem != null)
            {
                selectedBolum = (model.Bolum)listBoxBolumler.SelectedItem;
                bolumAdTextBox.Text = selectedBolum.BolumAd;
                fakulteComboBox.SelectedValue = selectedBolum.FakulteId;
            }
        }
    }
}

