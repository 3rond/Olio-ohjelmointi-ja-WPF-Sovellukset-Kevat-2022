using System;
using System.Collections.Generic;
using System.Text;

namespace perintä
{
    class henkilö
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        private static int instanssit = 0; // henkilön staattinen muuttuja joilla voidaan laskea kuinka monta henkilö on luotu

        public henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;

            instanssit++; 
        }

        //virtalinen metodi jota voidaan ylilukea (override ) aliluokissa
        public virtual void Tulostatiedot()
        {
            Console.WriteLine("henkilö" + Nimi + " . ikä: " + Ikä + " henkilötunnus: " + Henkilötunnus);
        }

        public void syö()
        {
            Console.WriteLine(Nimi + "syö ruoka");
        }
        public void juo()
        { Console.WriteLine(Nimi + "juo vettä");
        }

        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("henkilöitä olemassa: " + instanssit);
        }
    }
}
