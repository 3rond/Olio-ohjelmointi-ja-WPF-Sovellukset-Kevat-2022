using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus7
{
    class Hissi
    {
        private int minKerros;
        private int maxKerros;


        private int nykyinenKerros;

        public Hissi(int minKerros, int maxKerros)
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;
        }

        public Hissi(int minKerros, int maxKerros, int nykyinenKerros)
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

            nykyinenKerros = minKerros;
        }

        public int NykinenKerros
        {
            get => nykyinenKerros;
            set
            {
                if(value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("virheellinen kerros! ");
                }
                else
                {
                nykyinenKerros = value;
                    
                }
            }
        }
    }
}
