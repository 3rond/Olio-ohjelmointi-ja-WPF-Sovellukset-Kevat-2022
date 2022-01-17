using System;
using System.Collections.Generic;
namespace Harjoitus_9__2_
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Kanava> kanavat = new List<Kanava>();
            LisääKanavat(kanavat);
            Radio radio = new Radio();
            radio.KanavaanYhdistetty(kanavat);
            

            static void LisääKanavat(List<Kanava> kanavat)
            { 
            kanavat.Add(new Kanava("Yle", 99.2f));
            kanavat.Add(new Kanava("Radio", 104.2f));
            kanavat.Add(new Kanava("iskelmä", 100.2f));
            kanavat.Add(new Kanava("NRJ", 95.2f));

            }
            


        }
    }
}

