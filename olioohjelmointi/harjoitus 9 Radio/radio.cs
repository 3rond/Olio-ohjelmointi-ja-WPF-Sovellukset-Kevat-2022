using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_9_Radio
{
    class radio
    {
        public bool Tila = false;
        public void näytätiedot()
        {
            if (Tila) //if tila = true
            {
                Console.WriteLine("radio on päällä");
            }
            else
            {
                Console.WriteLine( "ei ole päällä");
            }
        }
    }
}
