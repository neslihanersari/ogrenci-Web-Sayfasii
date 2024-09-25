using System;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class Fakulte : Form
    {
        public Fakulte()
        {
            InitializeComponent();
        }

        private void FakulteAd_Click(object sender, EventArgs e)
        {
            // Bu event gereksiz görünüyor, kaldırabilirsiniz.
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string fakulteAd = FakulteAdrichTextBox1.Text; // TextBox'dan fakülte adını al
            if (!string.IsNullOrEmpty(fakulteAd))
            {
                using (var context = new AppDbContext())
                {
                    var fakulte = new model.Fakulte { FakulteAd = fakulteAd };
                    context.Fakulteler.Add(fakulte);
                    context.SaveChanges();
                }
                MessageBox.Show("Fakülte başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Fakülte adı boş olamaz.");
            }
        }

        private void Fakulte_Load(object sender, EventArgs e)
        {

        }
    }
}
