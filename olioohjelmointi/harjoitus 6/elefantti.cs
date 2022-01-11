using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
    class elefantti : Eläin
    {
        public int Ikä;
        public string koko;

        public static int instanssit = 0;

        public elefantti(string Koko, int ikä)
        {
            koko = Koko;
            Ikä = ikä;

            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("eläimiä on elossa " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("meow");
        }
    }
}
