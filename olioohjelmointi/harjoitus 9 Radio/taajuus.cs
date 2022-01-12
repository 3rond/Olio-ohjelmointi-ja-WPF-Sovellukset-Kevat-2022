using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9_Radio
{
    class taajuus
    {
        private int mintaajuu;
        private int maxtaajuu;


        private int nykyinentaajuu;

        public taajuus(int mintaajuu, int maxtaajuu)
        {
            this.mintaajuu = mintaajuu;
            this.maxtaajuu = maxtaajuu;
        }

        public taajuus(int mintaajuu, int maxtaajuu, int nykyinentaajuu)
        {
            this.mintaajuu = mintaajuu;
            this.maxtaajuu = maxtaajuu;

            nykyinentaajuu = mintaajuu;
        }

        public int Nykinentaajuu
        {
            get => nykyinentaajuu;
            set
            {
                if (value > maxtaajuu || value < mintaajuu)
                {
                    Console.WriteLine("Taajus on liian iso tai pieni 88.0-107.9! ");
                }
                else
                {
                    nykyinentaajuu = value;

                }
            }
        }
    }
}
