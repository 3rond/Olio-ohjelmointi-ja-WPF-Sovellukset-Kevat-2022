using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_13
{
    class Joukkue
    {
        public string Nimi;
        public string Kotikaupunki;
        public int Pelaajat;

        public Joukkue(string nimi, string kotikaupunki, int pelaajat)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = pelaajat;
        }

        public void Tulostatiedot()
        {
            Console.WriteLine("Joukkueen nimi : " + Nimi + " Kotikaupunki " + Kotikaupunki + " pelaajien määrä" + Pelaajat);
        }

    }
}
