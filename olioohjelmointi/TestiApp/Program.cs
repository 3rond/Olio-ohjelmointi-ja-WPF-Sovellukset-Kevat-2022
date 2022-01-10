using System;

namespace TestiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira();// ensimmäinen koira olio
            koira1.nimi = "Rekku";
            koira1.Ikä = 4;
            koira1.rotu = "saksanpaimenkoira";
            
            koira1.hauku();
            koira1.TulostaData();

            koira koira2= new koira();
            koira2.nimi = "asd";
            koira2.Ikä = 3;
            koira2.rotu = "mopsi";

            koira2.TulostaData();

            koira koira3 = new koira("urho", 5, "mopsi"); // uusi koira olio, joilla on määritelty nimi, ikä ja rotu luonti vaiheessa.

           
        }
    }
}
