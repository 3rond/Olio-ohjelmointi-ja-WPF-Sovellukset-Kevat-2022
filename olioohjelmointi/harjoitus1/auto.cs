using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus1
{
    class auto
    {
        public string nimi;
        public int nopeus;
        public int renkaat;

        public void tulostus()
        {
            Console.WriteLine("ajoneuvo " + nimi + " nopeus " + nopeus + " renkaat "+renkaat);
        }
    }
}
