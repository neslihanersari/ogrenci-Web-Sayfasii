using System;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            LoadDersler();
        }

        private void LoadDersler()
        {
            using (var context = new AppDbContext())
            {
                var dersler = context.Dersler.ToList();
                DerslerListBox.DataSource = dersler;
                DerslerListBox.DisplayMember = "DersAd";
                DerslerListBox.ValueMember = "DersId";
            }
        }

        private void Eklebutton1_Click(object sender, EventArgs e)
        {
            string dersAd = DersAdrichTextBox1.Text;

            if (!string.IsNullOrEmpty(dersAd))
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var ders = new model.Ders { DersAd = dersAd };
                        context.Dersler.Add(ders);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Ders başarıyla eklendi.");
                    LoadDersler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders eklenirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ders adını doğru şekilde doldurun.");
            }
        }

        private void Silbutton2_Click(object sender, EventArgs e)
        {
            if (DerslerListBox.SelectedItem != null)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var selectedDers = (model.Ders)DerslerListBox.SelectedItem;
                        var ders = context.Dersler.Find(selectedDers.DersId);
                        if (ders != null)
                        {
                            context.Dersler.Remove(ders);
                            context.SaveChanges();
                            MessageBox.Show("Ders başarıyla silindi.");
                            LoadDersler();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders silinirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
            }
        }

        private void Guncellebutton3_Click(object sender, EventArgs e)
        {
            if (DerslerListBox.SelectedItem != null)
            {
                string dersAd = DersAdrichTextBox1.Text;

                if (!string.IsNullOrEmpty(dersAd))
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var selectedDers = (model.Ders)DerslerListBox.SelectedItem;
                            var ders = context.Dersler.Find(selectedDers.DersId);
                            if (ders != null)
                            {
                                ders.DersAd = dersAd;
                                context.SaveChanges();
                                MessageBox.Show("Ders başarıyla güncellendi.");
                                LoadDersler();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ders güncellenirken bir hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen ders adını doğru şekilde doldurun.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz dersi seçin.");
            }
        }

        private void DerslerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DerslerListBox.SelectedItem != null)
            {
                var selectedDers = (model.Ders)DerslerListBox.SelectedItem;
                DersAdrichTextBox1.Text = selectedDers.DersAd;
            }
        }

        private void DersAdrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
