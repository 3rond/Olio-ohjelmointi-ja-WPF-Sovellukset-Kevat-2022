using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class opsikelijat
    {
        private string nimi;
        private string id;
        private int pisteet;
       

        public opsikelijat(string _nimi,string _id, int _pisteet)
        {
            nimi = _nimi;
            id = _id;
            pisteet = _pisteet;
        }
        public void tulostaData()
        {
            Console.WriteLine(nimi +  " .id " + id + " . pisteet " + pisteet);
        }
        public void muokkaaopintopisteitä(int määrä)
        {
            pisteet += määrä;
        }
    }
}
