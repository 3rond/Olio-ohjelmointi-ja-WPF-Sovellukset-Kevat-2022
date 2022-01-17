using System;
using System.Collections.Generic;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. Lisää opiskelijan kokoelman");
                Console.WriteLine("2. poista opiskelijan kokoelmasta");
                Console.WriteLine("3. tulosta opiskelijan kokoelma");
                Console.WriteLine("4. poistu - poistu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":
                        LisääOpiskelija(opiskelijat);

                        break;
                    case "poista":
                        PoistaOpiskelija(opiskelijat);
                        break;
                    case "tulosta":
                        TulostaOpiskelijat(opiskelijat);
                        break;
                    case "poistu":
                        return;
                    default:
                        break;
                }
            }
        }

        static void LisääOpiskelija(Dictionary<int,Opiskelija> opiskelijat)
        {
            Opiskelija uusiopiskelija = new Opiskelija();

            while(true)
            {
                Console.WriteLine("anna uudelle opiskelijalle tiedot :");
                Console.WriteLine("Etunimi :");
                uusiopiskelija.Etunimi = Console.ReadLine();
                Console.WriteLine(" sukunimi: ");
                uusiopiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine(" Ryhmätunnus: ");
                uusiopiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine(" OpiskelijaID: ");
                uusiopiskelija.OpsikelijaNumero = Convert.ToInt32(Console.ReadLine());

                if (opiskelijat.ContainsKey(uusiopiskelija.OpsikelijaNumero))
                {
                    Console.Write("Opiskelija Sanakirjassa on opiskelija samalla ID:llä");
                    continue; // continue skippaa nykyisen iteraation silmukasta ja aloittaa alusta
                }
                else
                {
                    opiskelijat.Add(uusiopiskelija.OpsikelijaNumero, uusiopiskelija);
                    break;
                }
            }
        }
        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan opiskelijaID jonka haluat poistaa");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("opiskelija poistettu" + opiskelijat[syöte].Etunimi + "poistettu");
            }
            else
            {
                Console.WriteLine("opiskelijaa ID:llä" + syöte + "ei löydetty kokoelmasta");
            }
            opiskelijat.Remove(syöte);
        }
        static void TulostaOpiskelijat(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach (Opiskelija item in opiskelijat.Values)
            {
                item.Tulostatiedot();
            }

        }
    }
}
