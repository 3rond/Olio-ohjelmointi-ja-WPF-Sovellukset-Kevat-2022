using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_9__2_
{
    class Kanava
    {
        public string Nimi;
        public float Taajuus;

        public Kanava(string nimi, float taajuus)
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
