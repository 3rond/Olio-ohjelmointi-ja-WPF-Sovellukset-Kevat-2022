using System;

namespace harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);
            string syöte;

            while (true)
            {
                Console.WriteLine("olet kerroksessa " + hissi.NykinenKerros);
                Console.WriteLine("mihin kerrokseen haluat siirtyä? ");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine("poistuit hissistä");
                    break;
                }
                else
                {
                    hissi.NykinenKerros = int.Parse(syöte);
                }

            }
        }
    }
}
