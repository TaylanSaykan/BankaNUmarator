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

            // S�ra numaralar�n� ba�lat
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

            // M��teriye s�ra numaras� ata
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

            // M��teriyi listeye ekle
            musteriler.Add(yeniMusteri);

            // M��teriyi �ncelik s�ras�na g�re s�rala
            musteriler = musteriler.OrderByDescending(m => m.MusteriTipi == MusteriTipi.VIP).ToList();

            // Bilgileri temizle
            txtAd.Text = "";
            txtSoyad.Text = "";

            // M��teriyi listbox'a ekle
            lbMusteriler.Items.Add(yeniMusteri);
        }

        private void btnMusteriDetay_Click(object sender, EventArgs e)
        {
            Musteri seciliMusteri = (Musteri)lbMusteriler.SelectedItem;
            if (seciliMusteri != null)
            {
                string detaylar = $"Ad: {seciliMusteri.Ad}\n" +
                                  $"Soyad: {seciliMusteri.Soyad}\n" +
                                  $"S�ra Numaras�: {seciliMusteri.SiraNumarasi}\n" +
                                  $"M��teri Tipi: {seciliMusteri.MusteriTipi}";

                MessageBox.Show(detaylar, "M��teri Detaylar�");
            }
        }

        private void btnGise_Click(object sender, EventArgs e)
        {


            GiseForm giseForm = new GiseForm();
            giseForm.Show();


        }
    }
}