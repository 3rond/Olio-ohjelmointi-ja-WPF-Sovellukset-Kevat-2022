using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Varis : Animal, ICanFly
    {
        public float WingSize { get; set; }
        public Varis(float wingSize)
        {
            WingSize = wingSize;
        }


        public void Fly()
        {
            Console.WriteLine("varis lentää . variksen siippien koko on " + WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("kakaaw kakaaw");
        }
    }
}
