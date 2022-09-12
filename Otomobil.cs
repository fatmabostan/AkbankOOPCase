using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    public class Otomobil:AracKayit
    {
        public int otomobil = 0;
        public Otomobil()
        { otomobil++; }

        public const string aracinSinifi = "1";
        public void BakiyeSorgu()
        {
            GiseGecis _gisegecis = new GiseGecis();
            Console.WriteLine("Kalan bakiyeniz: " + _gisegecis.setBakiye(bakiye, aracinSinifi));
        }
    }
}
