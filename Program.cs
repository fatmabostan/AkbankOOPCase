using System;

namespace PatikaAkbankHGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Minibus minibus = new Minibus();
            minibus.aracHGSNo = 5555555;
            minibus.bakiye = 20;
            minibus.Sahip_isimSoyisim = "Fatma Bostan";
            minibus.BakiyeSorgu();
        }
    }
}
