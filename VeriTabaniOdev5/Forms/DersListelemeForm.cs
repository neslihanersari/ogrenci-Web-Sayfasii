using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class DersListelemeForm : Form
    {
        public DersListelemeForm()
        {
            InitializeComponent();
        }

        private void DersListelemeForm_Load(object sender, EventArgs e)
        {
            // Form yüklenirken yapılacak işlemler
        }

        private void ListeleOgrenciButton_Click(object sender, EventArgs e)
        {
            string ogrenciNo = OgrenciNoTextBox.Text;

            using (var context = new AppDbContext())
            {
                var ogrenciDersler = context.Ogrencidersler
                    .Where(od => od.Ogrenci.OgrenciId.ToString() == ogrenciNo)
                    .Select(od => new
                    {
                        od.Ders.DersAd,
                        od.Yil,
                        od.YariYil,
                        od.Vize,
                        od.Final
                    })
                    .ToList();

                OgrenciDerslerDataGridView.DataSource = ogrenciDersler;
                OgrenciDerslerDataGridView.Columns["DersAd"].HeaderText = "Ders Adı";
                OgrenciDerslerDataGridView.Columns["Yil"].HeaderText = "Yıl";
                OgrenciDerslerDataGridView.Columns["YariYil"].HeaderText = "Yarıyıl";
                OgrenciDerslerDataGridView.Columns["Vize"].HeaderText = "Vize Notu";
                OgrenciDerslerDataGridView.Columns["Final"].HeaderText = "Final Notu";
            }
        }

        private void ListeleYilButton_Click(object sender, EventArgs e)
        {
            int yil = int.Parse(YilTextBox.Text);
            int yariYilIndex = YariYilComboBox.SelectedIndex;

            // Yarıyıl bilgisini combobox'dan alıp 1 ekleyerek yarıyıl numarasına çeviriyoruz
            int yariYil = yariYilIndex + 1;

            using (var context = new AppDbContext())
            {
                var dersSecim = context.Dersler
                    .Select(d => new
                    {
                        DersAd = d.DersAd,
                        OgrenciSayisi = d.OgrenciDersler
                            .Count(od => od.Yil == yil && od.YariYil == yariYil)
                    })
                    .ToList();

                DersSecimDataGridView.DataSource = dersSecim;
                DersSecimDataGridView.Columns["DersAd"].HeaderText = "Ders Adı";
                DersSecimDataGridView.Columns["OgrenciSayisi"].HeaderText = "Öğrenci Sayısı";
            }
        }

        private void OgrenciDerslerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
