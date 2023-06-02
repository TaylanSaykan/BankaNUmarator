using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form2 : Form
    {
        private ListBox mainListBox;

        public Form2(ListBox listBox)
        {
            InitializeComponent();
            mainListBox = listBox;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(mainListBox.Items.Cast<Musteri>().ToArray());
        }

        private void lblGise1SıraNo_Click(object sender, EventArgs e)
        {

        }

        private void lblGise2SıraNo_Click(object sender, EventArgs e)
        {

        }

        private void lblGise1Ad_Click(object sender, EventArgs e)
        {

        }

        private void lblGise1Soyad_Click(object sender, EventArgs e)
        {

        }

        private void lblGise1Tip_Click(object sender, EventArgs e)
        {

        }

        private void cbİslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnİslemTamam1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Musteri seciliMusteri)
            {
                listBox1.Items.Remove(seciliMusteri);
                UpdateGiseLabels(); // Gişe bilgilerini güncelle
            }
        }

        private void btnSıradaki1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Musteri siraNumarasiEnKucukMusteri = listBox1.Items.Cast<Musteri>()
                    .OrderBy(m => m.SiraNumarasi)
                    .First();

                listBox1.Items.Remove(siraNumarasiEnKucukMusteri);
                UpdateGiseLabels(); // Gişe bilgilerini güncelle
            }
        }
    }

    private void lblGise2Ad_Click(object sender, EventArgs e)
    {

    }

    private void lblGise2SoyAd_Click(object sender, EventArgs e)
    {

    }

    private void lblGise2Tur_Click(object sender, EventArgs e)
    {

    }

    private void cbİslemTuru2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnİslemTamam2_Click(object sender, EventArgs e)
    {
        if (listBox2.SelectedItem is Musteri seciliMusteri)
        {
            listBox2.Items.Remove(seciliMusteri);
            UpdateGiseLabels()
        }

        private void btnSıradaki2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                Musteri siraNumarasiEnKucukMusteri = listBox2.Items.Cast<Musteri>()
                    .OrderBy(m => m.SiraNumarasi)
                    .First();

                object listBox2 = null;
                listBox2.Items.Remove(siraNumarasiEnKucukMusteri);
                UpdateGiseLabels();
            }
        }


        private void UpdateGiseLabels()
        {
            object listBox1 = null;
            // Gişe 1 bilgilerini güncelle
            if (listBox1.Items.Count > 0)
            {
                Musteri gise1Musteri = (Musteri)listBox1.Items[0];
                lblGise1SıraNo.Text = gise1Musteri.SiraNumarasi.ToString();
                lblGise1Ad.Text = gise1Musteri.Ad;
                lblGise1Soyad.Text = gise1Musteri.Soyad;
                lblGise1Tip.Text = gise1Musteri.MusteriTipi.ToString();
            }
            else
            {
                lblGise1SıraNo.Text = "-";
                lblGise1Ad.Text = "-";
                lblGise1Soyad.Text = "-";
                lblGise1Tip.Text = "-";
            }

            // Gişe 2 bilgilerini güncelle
            if (listBox2.Items.Count > 0)
            {
                Musteri gise2Musteri = (Musteri)listBox2.Items[0];
                lblGise2SıraNo.Text = gise2Musteri.SiraNumarasi.ToString();
                lblGise2Ad.Text = gise2Musteri.Ad;
                lblGise2SoyAd.Text = gise2Musteri.Soyad;
                lblGise2Tur.Text = gise2Musteri.MusteriTipi.ToString();
            }
            else
            {
                lblGise2SıraNo.Text = "-";
                lblGise2Ad.Text = "-";
                lblGise2SoyAd.Text = "-";
                lblGise2Tur.Text = "-";
            }
        }
}
