using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus3
{
    class kiuas
    {
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;
        public bool Tila = false;

        public kiuas(string _nimi,int _Lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpötila = _Lämpötila;
            Kosteus = _kosteus;
        }

        public void näytätiedot()
        {
            if(Tila) //if tila = true
            {
                Console.WriteLine("kiuas " + Nimi + " on päällä");
                Console.WriteLine("lämpötila =" + Lämpötila);
                Console.WriteLine("kosteus =" + Kosteus);
            } else
            {
                Console.WriteLine("kiuas" + Nimi + " ei ole päällä");
            }
        }
        public void säädälämpötila(itn uusilämpötila)
        {
            Lämpötila = uusilämpötila; 
        }
    }
}
