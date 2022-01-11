using System;

namespace perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            henkilö henkilö1 = new henkilö(" matti", 20,10293049);//henkilö olio
            opiskelija opiskelija1 = new opiskelija("pekka",17,219384,12345,"Careeria"); //n oiskelija olio, opsikelija on henkilö

            henkilö1.Tulostatiedot();
            opiskelija1.Tulostatiedot();

            henkilö1.syö();
            henkilö1.juo();
            Console.WriteLine("");
            opiskelija1.opiskele();
            opiskelija1.syö();
            opiskelija1.juo();

            henkilö.KuinkaMontaHenkilöä();
            opiskelija.KuinkaMontaOpiskelijaa();
           
        }


    }
}
