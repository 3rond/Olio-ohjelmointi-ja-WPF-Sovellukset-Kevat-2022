using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus4
{
    class albumi
    {

        public string artisti;
        public string nimi;
        public string genre;
        public int hinta;
        private List<kappaleluoka> kappaleet = new List<kappaleluoka>();

        public albumi(string artisti, string nimi, string genre, int hinta)
        {
            this.artisti = artisti;
            this.nimi = nimi;
            this.genre = genre;
            this.hinta = hinta;
        }

        public void lisääkappale(kappaleluoka uusikappale)
        {
            kappaleet.Add(uusikappale);
            
        }

        public void tulostakappaleet()
        {
            foreach (kappaleluoka  kappale in kappaleet)
            {
                Console.WriteLine(kappale.nimi + "," + kappale.pituus +"," );
            }
            
        }


        public void tulostaAlbumi()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("artisti = " + artisti);
            Console.WriteLine("nimi = "+ nimi);
            Console.WriteLine("genre = " + genre);
            Console.WriteLine("hinta = " + hinta);

            tulostakappaleet();
            Console.WriteLine("-----------------------------------------");
        }
        
    }
}
