using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    class Yonetim:GiseGecis

    {   public void ToplamBakiye(List<AracKayit> araclar)
        {   int otomobil=0, minibus=0, otobus=0;
            for(int i=0; i<araclar.Count; i++)
                if(araclar[i].aracSinifi==1)
                    otomobil++;
            else if(araclar[i].aracSinifi==2)
                    minibus++;
            else
                    otobus++;

            int bakiye = minibusUcret * minibus + otobusUcret * otomobil + otobusUcret * otobus;
            Console.WriteLine("Toplam kazancınız: "+ bakiye);
        }


    }
}
