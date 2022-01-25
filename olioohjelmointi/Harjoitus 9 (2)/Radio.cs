using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_9__2_
{
    class Radio
    {
        private int äänenvoimakkuus;
        private float Taajuus;

        public bool kytkin { get; set; }

        public int Äänenvoimakkuus
        {
            get { return äänenvoimakkuus; }
            set
            {
                if (value > 9)
                {
                    äänenvoimakkuus = 9;
                }
                else if (value < 0)
                { äänenvoimakkuus = 0; }
                else
                {
                    äänenvoimakkuus = value;
                }
            }
        }

        public void KanavaanYhdistetty(List<Kanava> kanavat)
        {
            foreach (Kanava value in kanavat)

                if (value.Taajuus == 108)

                    break;

        }
    }

}

