using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_8
{
    class työntekijö :henkilö
    {
        public override string Nimi { get; set; }
        public override string Työpaikka { get; set; }
        public override int Palkka { get; set; }

        public int viikkoTunnit;
        

        public työntekijö(string nimi, string työpaikka, int palkka)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
           
        }

        public työntekijö(string nimi, string työpaikka, int palkka, int viikkoTunnit) : this(nimi, työpaikka, palkka)
        {
            this.viikkoTunnit = viikkoTunnit;
        }

        public void työntekijätiedot()
        {
            Console.WriteLine("nimi on " + Nimi + "työpaikka " + Työpaikka + " palkka on " + Palkka +" viikkotunnit " + viikkoTunnit);
        }
    }
}
