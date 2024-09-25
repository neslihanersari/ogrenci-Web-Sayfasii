using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.Forms
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                Fakulte Fakulte = new Fakulte();
                Fakulte.Show();
            }
        }

        private void BolumEkle_Click(object sender, EventArgs e)
        {
            {
                Bolum Bolum = new Bolum();
                Bolum.Show();
            }
        }

        private void OgrenciEkle_Click(object sender, EventArgs e)
        {
            {
                Ogrenci Ogrenci = new Ogrenci();
                Ogrenci.Show();
            }

        }

        private void OgrenciSorgula_Click(object sender, EventArgs e)
        {

            OgrenciDersForm ogrenciDersForm = new OgrenciDersForm();
            ogrenciDersForm.Show();
        }
        private void DersEkle_Click(object sender, EventArgs e)
        {
            Ders dersForm = new Ders();
            dersForm.Show();

        }

        private void OgrenciSorgulaWeb_Click(object sender, EventArgs e)
        {
            OgrenciDersNotGirisiForm ogrenciDersNotGirisiForm = new OgrenciDersNotGirisiForm();
            ogrenciDersNotGirisiForm.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void ListelemeEkranıbutton1_Click(object sender, EventArgs e)
        {
            DersListelemeForm dersListelemeForm = new DersListelemeForm();
            dersListelemeForm.Show();
        }
    }
}
