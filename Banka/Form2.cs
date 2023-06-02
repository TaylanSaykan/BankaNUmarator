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
    public partial class GiseForm : Form
    {
        private readonly List<İslemTuru> İslemler;
        private string ParaCekme;
        private string ParaYatırma;
        private string KrediBaşvurusu;
        private string Diger;




        public GiseForm()
        {
            InitializeComponent();

            İslemler = new List<İslemTuru>();

            ParaCekme = "Para Çekme";
            ParaYatırma = "Para Yatırma";
            KrediBaşvurusu = "Kredi Başvurusu";
            Diger = "Diger";

            cbGise1İslemTuru.Items.Add(ParaCekme);
            cbGise1İslemTuru.Items.Add(ParaYatırma);
            cbGise1İslemTuru.Items.Add(KrediBaşvurusu);

            cbGise2İslemTuru.Items.Add(ParaCekme);
            cbGise2İslemTuru.Items.Add(ParaYatırma);
            cbGise2İslemTuru.Items.Add(KrediBaşvurusu);



        }

        public object Diğer { get; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
