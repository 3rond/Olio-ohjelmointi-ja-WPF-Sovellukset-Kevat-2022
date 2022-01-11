using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_8
{
    class pomo : henkilö
    {
        public override string Nimi { get ; set ; }
        public override string Työpaikka { get; set ; }
        public override int Palkka { get ; set ; }

        public int bonus;
        public string auto;

        private static int instanssi = 1;
        public pomo()
        {
            if (instanssi >0)
            {
                Console.WriteLine("pomo on jo olemassa ei voidaan luoda uuden ");
                return;
            }
            instanssi++;
           
        }
        public static new void KuinkaMonta()
        {

            Console.WriteLine("pomoja on " + instanssi);
        }



        public pomo(string nimi, string työpaikka, int palkka, int bonus, string auto)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
            this.bonus = bonus;
            this.auto = auto;
        }

        public void pomontiedot()
        {
            Console.WriteLine("nimi on " + Nimi + "työpaikka " + Työpaikka + " palkka on " + Palkka + " bonus " + bonus + "auto" + auto);
        }
    }
}
