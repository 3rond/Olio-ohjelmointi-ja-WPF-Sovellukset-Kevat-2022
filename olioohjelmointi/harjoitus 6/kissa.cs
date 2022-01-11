using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
    class kissa : Eläin
    {
        public int Ikä;
        public string Väri;

        public static int instanssit = 0;

        public kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("eläimiä on elossa " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("meow");
        }
    }
}
