using System;

namespace Abstraktisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            opiskelija opiskelija1 = new opiskelija();
            opiskelija1.Nimi = "pekka";
            opiskelija1.puhu();
            Henkilö.KuinkaMonta();
        }
    }
}
