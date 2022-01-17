using System;
using System.Collections.Generic;

namespace Harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICanFly> LentoEläimet = new List<ICanFly>();
            List<ICanSwim> UimaEläimet = new List<ICanSwim>();

            Varis varis1 = new Varis(5);
            Sorsa sorsa1 = new Sorsa(4,7);
            varis1.Fly();
            varis1.MakeASound();
            sorsa1.Fly();
            sorsa1.MakeASound();
            sorsa1.Swim();

            Console.WriteLine("variksen tyyppi on " + varis1.GetType());

           

            LentoEläimet.Add(varis1);
            LentoEläimet.Add(sorsa1);

            UimaEläimet.Add(sorsa1);

        }
    }
}
