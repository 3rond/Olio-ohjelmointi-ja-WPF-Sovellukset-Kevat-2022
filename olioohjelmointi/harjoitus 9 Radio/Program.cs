using System;

namespace harjoitus_9_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            ääni ääni1 = new ääni(0, 9);
            taajuus taajuu1 = new taajuus(88, 107);
            string syöte;
            string syöte1;
            radio radio1 = new radio();
            radio1.näytätiedot();
            

            while (true)
            {
                Console.WriteLine("voluumisi on : " + ääni1.Nykinenääni);
                Console.WriteLine("säädä voluumisi" +
                    " tai sammuta radiota kirjoittamalla -sammuta ");
                syöte = Console.ReadLine();

                if (syöte == "sammuta")
                {
                    Console.WriteLine("sammutit radio");
                 
                }
                else
                {
                    ääni1.Nykinenääni = int.Parse(syöte);
                }

            
            
                Console.Write("taajuus on : " + taajuu1.Nykinentaajuu);
                Console.Write(" säädä taajuus tai " +
                    "sammuta radiota kirjoittamalla -sammuta");
                syöte1 = Console.ReadLine();
                if (syöte1 == "sammuta")
                {
                    Console.WriteLine("sammutit radio");
                    break;
                }
                else
                {
                taajuu1.Nykinentaajuu = int.Parse(syöte);
                    
                }
            
            }
        }
    }
}

