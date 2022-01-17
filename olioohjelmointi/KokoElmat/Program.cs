using System;
using System.Collections.Generic;

namespace KokoElmat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("pekka");
            lista.Add("matti");
            lista.Add("juha");

            lista.Remove("matti");
            //lista.removeAt(1)

            //käydään läpi listan
            // tyyppi - nimi in kokoelma
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------PINO-----------------");
            Stack<string> pino = new Stack<string>();

            pino.Push("kortti 1");
            pino.Push("kortti 2");
            pino.Push("kortti 3");

            Console.WriteLine("pinossa on " + pino.Count + " OBJEKTEJA");
            Console.WriteLine(pino.Peek()); //peek:in avulla saadan tietoon mikä objekti on 

            pino.Pop();

            Console.WriteLine("pinossa on " + pino.Count + " OBJEKTEJA");
            Console.WriteLine(pino.Peek());

            Console.WriteLine("---------PINO-----------------");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("matti");
            jono.Enqueue("pekka");
            jono.Enqueue("juha");
            Console.WriteLine("jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            jono.Dequeue();

            Console.WriteLine("jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("----------SANAKIRJA-----------------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("12384-3214", "matti");
            sanakirja.Add("344384-6754", "pekka");

            Console.WriteLine("sanakirjassa on " + sanakirja.Count + " henkilöa");

            foreach (string avain in sanakirja.Keys)
            {
                Console.WriteLine("sanakirjasta haettu avaimella :" + avain + ". value " + sanakirja[avain]);
            }
            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine(henkilö);
            }
            Console.WriteLine(" etsitään sanakirjasta avaimella '12384-3214 ' , haettua henkilö " + sanakirja["12384-3214"]);

            sanakirja.Add("12384-3214", "juha");



        }
    }
}
