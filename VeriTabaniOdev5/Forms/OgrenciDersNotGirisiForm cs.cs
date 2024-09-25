using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class OgrenciDersNotGirisiForm : Form
    {
        public OgrenciDersNotGirisiForm()
        {
            InitializeComponent();
        }

        private void OgrenciDersNotGirisiForm_Load(object sender, EventArgs e)
        {
            LoadDersler();
        }

        private void LoadDersler()
        {
            using (var context = new AppDbContext())
            {
                var dersler = context.Dersler.ToList();
                DersComboBox.DataSource = dersler;
                DersComboBox.DisplayMember = "DersAd";
                DersComboBox.ValueMember = "DersId";
            }
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            int selectedDersId = (int)DersComboBox.SelectedValue;
            using (var context = new AppDbContext())
            {
                var ogrenciDersler = context.Ogrencidersler
                    .Where(od => od.DersId == selectedDersId)
                    .Select(od => new
                    {
                        od.OgrenciDersId,
                        od.Ogrenci.Ad,
                        od.Vize,
                        od.Final
                    })
                    .ToList();

                OgrenciDersDataGridView.DataSource = ogrenciDersler;
            }
        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in OgrenciDersDataGridView.Rows)
                {
                    if (row.Cells["OgrenciDersId"].Value != null)
                    {
                        int ogrenciDersId = (int)row.Cells["OgrenciDersId"].Value;
                        var ogrenciDers = context.Ogrencidersler.Find(ogrenciDersId);
                        ogrenciDers.Vize = Convert.ToInt32(row.Cells["Vize"].Value);
                        ogrenciDers.Final = Convert.ToInt32(row.Cells["Final"].Value);
                        context.Entry(ogrenciDers).State = EntityState.Modified;
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show("Notlar kaydedildi.");
        }

        private void OgrenciDersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
