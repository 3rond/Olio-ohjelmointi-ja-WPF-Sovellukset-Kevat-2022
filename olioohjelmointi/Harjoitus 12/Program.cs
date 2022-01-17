using System;
using System.Collections.Generic;

namespace Harjoitus_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                pakka.Add("pata " + (i + 1));
                pakka.Add("hertta " + (i + 1));
                pakka.Add("risti " + (i + 1));
                pakka.Add("ruutu " + (i + 1));
            }
            Randomize(pakka);
            for (int i = 0; i < pakka.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + "kortti on " +  pakka[i]);
            }
        }
        public static void Randomize (List<string> items)
        {
            Random rand = new Random();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < items.Count - 1; i++)
            {
                int j = rand.Next(i, items.Count);
                string temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }
}
