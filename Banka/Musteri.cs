using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Musteri
    {
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SiraNumarasi { get; set; }
        public MusteriTipi MusteriTipi { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} (Sıra No: {SiraNumarasi})";
        }
    }

    // Müşteri tipleri
    public enum MusteriTipi
    {
        VIP,
        SadikMusteri,
        MaasMusterisi,
        NormalMusteri
    }
}

