using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
   abstract class Eläin
    {
        private static int instanssit = 0;//laskee kuinka monta eläintä on olemassa

        public Eläin()
        {
            instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("eläimiä on elossa " + instanssit);
        }

        public abstract void Ääntele();
    }
}
