using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public enum İslemTuru
    {
        ParaCekme ,
        ParaYatırma,
        KrediBaşvurusu,
        Diğer
    }

    public class İslemTipi
    {
        private int _islemTuru;

        public int İslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }

    }
}
