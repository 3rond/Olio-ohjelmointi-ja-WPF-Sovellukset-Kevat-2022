using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }


        public abstract void puhu();// abstraktit metodit suljetaan ; aaltosulkuja ei käytetä

        public static int instanssi = 0;

        public Henkilö()
        {
            instanssi++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("henkilö elossa " + instanssi);
        }
    }
}
