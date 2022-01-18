using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_11
{
    class Opiskelija
    {
        public string Etunimi;
        public string Sukunimi;
        public string Ryhmätunnus;
        public int OpsikelijaNumero;

        public void Tulostatiedot()
        {
            Console.WriteLine("opsikelija : " + Etunimi + " " + Sukunimi);
            Console.WriteLine(". Ryhmätunnus " + Ryhmätunnus + " opiskelijanumero" + OpsikelijaNumero);
        }
    }
}
