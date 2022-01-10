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
