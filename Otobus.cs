using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    public class Otobus:AracKayit
    {
        public const string aracinSinifi = "3";
        public void BakiyeSorgu()
        {
          GiseGecis _gisegecis = new GiseGecis();  
          Console.WriteLine("Kalan bakiyeniz: " + _gisegecis.setBakiye(bakiye, aracinSinifi));
        }


    }
}
