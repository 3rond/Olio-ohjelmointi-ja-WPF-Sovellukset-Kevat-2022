using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_13
{
    class Pelaajat
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajanNumero;

        public void TulostaPelaajat()
        {
            Console.WriteLine("pelaajan nimi on " + Etunimi + "sukunimi " + Sukunimi + " pelaajanNumero" + PelaajanNumero);
        }
    }
}
