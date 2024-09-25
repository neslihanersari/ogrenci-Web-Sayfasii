using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VeriTabaniOdev5.data;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class OgrenciDersForm : Form
    {
        public OgrenciDersForm()
        {
            InitializeComponent();
        }

        private void OgrenciDersForm_Load(object sender, EventArgs e)
        {
            LoadOgrenciler();
            LoadDersler();
            LoadOgrenciDersler();
        }

        private void LoadOgrenciler()
        {
            using (var context = new AppDbContext())
            {
                var ogrenciler = context.Ogrenciler.ToList();
                OgrenciComboBox.DataSource = ogrenciler;
                OgrenciComboBox.DisplayMember = "OgrenciAd";
                OgrenciComboBox.ValueMember = "OgrenciId";
            }
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

        private void LoadOgrenciDersler()
        {
            using (var context = new AppDbContext())
            {
                var ogrenciDersler = context.Ogrencidersler.Include(od => od.Ogrenci).Include(od => od.Ders).ToList();
                OgrenciDersListBox.DataSource = ogrenciDersler;
                OgrenciDersListBox.DisplayMember = "OgrenciDersId";
            }
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var ogrenciDers = new OgrenciDers
                {
                    OgrenciId = (int)OgrenciComboBox.SelectedValue,
                    DersId = (int)DersComboBox.SelectedValue,
                    Yil = (int)YilNumericUpDown.Value,
                    YariYil = (int)YariYilNumericUpDown.Value
                };
                context.Ogrencidersler.Add(ogrenciDers);
                context.SaveChanges();
            }
            LoadOgrenciDersler();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            if (OgrenciDersListBox.SelectedItem != null)
            {
                using (var context = new AppDbContext())
                {
                    var ogrenciDers = (OgrenciDers)OgrenciDersListBox.SelectedItem;
                    context.Ogrencidersler.Attach(ogrenciDers);
                    context.Ogrencidersler.Remove(ogrenciDers);
                    context.SaveChanges();
                }
                LoadOgrenciDersler();
            }
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            if (OgrenciDersListBox.SelectedItem != null)
            {
                using (var context = new AppDbContext())
                {
                    var ogrenciDers = (OgrenciDers)OgrenciDersListBox.SelectedItem;
                    ogrenciDers.OgrenciId = (int)OgrenciComboBox.SelectedValue;
                    ogrenciDers.DersId = (int)DersComboBox.SelectedValue;
                    ogrenciDers.Yil = (int)YilNumericUpDown.Value;
                    ogrenciDers.YariYil = (int)YariYilNumericUpDown.Value;
                    context.Entry(ogrenciDers).State = EntityState.Modified;
                    context.SaveChanges();
                }
                LoadOgrenciDersler();
            }
        }

        private void OgrenciDersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OgrenciDersListBox.SelectedItem != null)
            {
                var ogrenciDers = (OgrenciDers)OgrenciDersListBox.SelectedItem;
                OgrenciComboBox.SelectedValue = ogrenciDers.OgrenciId;
                DersComboBox.SelectedValue = ogrenciDers.DersId;
                YilNumericUpDown.Value = ogrenciDers.Yil;
                YariYilNumericUpDown.Value = ogrenciDers.YariYil;
            }
        }
    }
}
