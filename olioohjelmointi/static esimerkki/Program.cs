using System;

namespace static_esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            float km = 154f;
            float mailit = muuntaja.KmToMiles(km);

            Console.WriteLine(km + "kilometriä on yhtäkuin " + mailit + "mailia");
        }
    }
}
