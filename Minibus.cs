﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaAkbankHGS
{
    public class Minibus : AracKayit
    {
        public int minibus = 0;
        public Minibus()
            { minibus++; }
        public const string aracinSinifi = "2";
        public void BakiyeSorgu()
        {
            GiseGecis _gisegecis = new GiseGecis();
            Console.WriteLine("Kalan bakiyeniz: " + _gisegecis.setBakiye(bakiye, aracinSinifi));
        }


    }
}
