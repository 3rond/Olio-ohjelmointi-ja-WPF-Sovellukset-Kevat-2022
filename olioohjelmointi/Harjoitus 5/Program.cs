using System;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 4;
            float b = 5;
            Console.WriteLine(Laskin.summa(a, b));
            Console.WriteLine(Laskin.erotus(a, b));
            Console.WriteLine(Laskin.kertolasku(a, b));
            Console.WriteLine(Laskin.jakolasku(a, b));
        }
    }
}
