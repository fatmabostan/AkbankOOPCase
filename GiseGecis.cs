using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    public class GiseGecis
    {   //ucretler tahmini girilmistir.
        public const int otobusUcret = 18;
        public const int minibusUcret = 15;
        public const int otomobilUcret = 10;

        public List<AracKayit> Add(AracKayit arac)
        {
            aracKayit.Add(arac);
            return aracKayit;
        }


        public int setBakiye(int bakiye, string aracinSinifi)
        {
            if (aracinSinifi == "1")
                bakiye -= otomobilUcret;
            else if (aracinSinifi == "2")
                bakiye -= minibusUcret;
            else
                bakiye -= otobusUcret;

            return bakiye;
        }


    }
}
