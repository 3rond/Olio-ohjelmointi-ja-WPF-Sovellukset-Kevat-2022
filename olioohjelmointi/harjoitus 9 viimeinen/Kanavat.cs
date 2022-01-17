using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9_viimeinen
{
    class Kanavat
    {
        public string Nimi;
        public float Taajuus;

        public Kanavat(string nimi, float taajuus)
        {
            Nimi = nimi;
            Taajuus = taajuus;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Kanava " + Nimi + " taajuudella" + Taajuus); 
        }
    }

}

