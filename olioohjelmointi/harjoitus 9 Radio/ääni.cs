using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9_Radio
{
    class ääni
    {

        private int minääni;
        private int maxääni;


        private int nykyinenääni;

        public ääni(int minääni, int maxääni)
        {
            this.minääni = minääni;
            this.maxääni = maxääni;
        }

        public ääni(int minääni, int maxääni, int nykyinenääni)
        {
            this.minääni = minääni;
            this.maxääni = maxääni;

            nykyinenääni = minääni;
        }

        public int Nykinenääni
        {
            get => nykyinenääni;
            set
            {
                if (value > maxääni || value < minääni)
                {
                    Console.WriteLine("voluumi ei pääse niin korkealle, Yritä uudestaan! ");
                }
                else
                {
                    nykyinenääni = value;

                }
            }
        }
    }
}
