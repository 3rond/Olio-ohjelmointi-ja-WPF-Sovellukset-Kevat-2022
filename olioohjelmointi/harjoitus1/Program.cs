using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            auto auto = new auto();
            auto mopo = new auto();
            auto vene = new auto();

            auto.nimi = "bmw";
            auto.nopeus = 200;
            auto.renkaat = 4;

            mopo.nimi = "mopo";
            mopo.nopeus = 140;
            mopo.renkaat = 2;

            vene.nimi = "buster";
            vene.nopeus = 80;
            vene.renkaat = 2;

            auto.tulostus();
            mopo.tulostus();
            vene.tulostus();

           

            
        }
    }
}
