using System;

namespace perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            henkilö henkilö = new henkilö(" matti", 20,10293049);//henkilö olio
            opiskelija opiskelija = new opiskelija("pekka",17,219384,12345,"Careeria"); //n oiskelija olio, opsikelija on henkilö

            henkilö.Tulostatiedot();
            opiskelija.Tulostatiedot();

            henkilö.syö();
            henkilö.juo();
            Console.WriteLine("");
            opiskelija.opiskele();
            opiskelija.syö();
            opiskelija.juo();
        }

    }
}
