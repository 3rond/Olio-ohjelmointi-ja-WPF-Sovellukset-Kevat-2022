using System;
using System.Collections.Generic;
using System.Text;

namespace TestiApp
{
    class koira
    {
        public string nimi;
        public int Ikä;
        public string rotu;


        public koira() { }
        //konsrkutori jonka avulla kaikki uudet koira oliot
        public koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            Ikä = _ikä;
            rotu = _rotu;

            hauku();
        }

        public void TulostaData()
        {
            Console.WriteLine("koiran nimi: " + nimi +  ".Ikä:" + Ikä+ " " + "rotu " + rotu);
            
            
        }

        public void hauku()
        {
            Console.WriteLine("woof woof");
        }
    }
}
