using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    class opiskelija : Henkilö
    {
        public override string Nimi { get ; set ; }

        public override void puhu()
        {
            Console.WriteLine(Nimi + " puhuu opiskelija luokassa");
        }
    }
}
