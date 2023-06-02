namespace Banka
{
    public partial class Form1 : Form
    {
        private List<Musteri> musteriler;
        private int vipSiraNumarasi;
        private int sadikSiraNumarasi;
        private int maasSiraNumarasi;
        private int normalSiraNumarasi;


        public Form1()
        {
            InitializeComponent();
            musteriler = new List<Musteri>();

            // Sýra numaralarýný baþlat
            vipSiraNumarasi = 1000;
            sadikSiraNumarasi = 2000;
            maasSiraNumarasi = 3000;
            normalSiraNumarasi = 4000;


            cbMusteriTipi.Items.Add(MusteriTipi.VIP);
            cbMusteriTipi.Items.Add(MusteriTipi.SadikMusteri);
            cbMusteriTipi.Items.Add(MusteriTipi.MaasMusterisi);
            cbMusteriTipi.Items.Add(MusteriTipi.NormalMusteri);
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                MusteriTipi = (MusteriTipi)cbMusteriTipi.SelectedIndex
            };

            // Müþteriye sýra numarasý ata
            switch (yeniMusteri.MusteriTipi)
            {
                case MusteriTipi.VIP:
                    yeniMusteri.SiraNumarasi = vipSiraNumarasi;
                    vipSiraNumarasi++;
                    break;
                case MusteriTipi.SadikMusteri:
                    yeniMusteri.SiraNumarasi = sadikSiraNumarasi;
                    sadikSiraNumarasi++;
                    break;
                case MusteriTipi.MaasMusterisi:
                    yeniMusteri.SiraNumarasi = maasSiraNumarasi;
                    maasSiraNumarasi++;
                    break;
                case MusteriTipi.NormalMusteri:
                    yeniMusteri.SiraNumarasi = normalSiraNumarasi;
                    normalSiraNumarasi++;
                    break;
            }

            // Müþteriyi listeye ekle
            musteriler.Add(yeniMusteri);

            // Müþteriyi öncelik sýrasýna göre sýrala
            musteriler = musteriler.OrderByDescending(m => m.MusteriTipi == MusteriTipi.VIP).ToList();

            // Bilgileri temizle
            txtAd.Text = "";
            txtSoyad.Text = "";

            // Müþteriyi listbox'a ekle
            lbMusteriler.Items.Add(yeniMusteri);
        }

        private void btnMusteriDetay_Click(object sender, EventArgs e)
        {
            Musteri seciliMusteri = (Musteri)lbMusteriler.SelectedItem;
            if (seciliMusteri != null)
            {
                string detaylar = $"Ad: {seciliMusteri.Ad}\n" +
                                  $"Soyad: {seciliMusteri.Soyad}\n" +
                                  $"Sýra Numarasý: {seciliMusteri.SiraNumarasi}\n" +
                                  $"Müþteri Tipi: {seciliMusteri.MusteriTipi}";

                MessageBox.Show(detaylar, "Müþteri Detaylarý");
            }
        }

        private void btnGise_Click(object sender, EventArgs e)
        {
            Form2 giseForm = new Form2(lbMusteriler);
            giseForm.Show();


        }
    }
}