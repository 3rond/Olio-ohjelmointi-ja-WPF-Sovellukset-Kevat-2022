using System;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            albumi albumi = new albumi("Pop Smoke","erond","hiphop rap",5);

            Console.WriteLine("------------------------------");
            albumi.lisääkappale(new kappaleluoka("kappale 1 ", "3:35"));
            albumi.lisääkappale(new kappaleluoka( "kappale 2 ", " 1:10"));
            albumi.lisääkappale(new kappaleluoka( "kappale 3 ", "3:03"));

            albumi.tulostaAlbumi();
            Console.WriteLine("-------------------------------------------");
        }
    }
}
