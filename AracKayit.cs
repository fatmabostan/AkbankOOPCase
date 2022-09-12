using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    public class AracKayit
    {
        public AracKayit()
        {
            GecisTarihi = DateTime.Now;
        }
        public int aracHGSNo;
        public string Sahip_isimSoyisim;
        public DateTime GecisTarihi;
        public int bakiye;
        public int aracSinifi;
    }
}
