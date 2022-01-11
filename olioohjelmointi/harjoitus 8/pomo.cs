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

        public int instanssi = 1;
        public pomo()
        {
            instanssi++;
           
        }
        public void hei()
        {
            Console.WriteLine("pomoja on vain" + instanssi);
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
