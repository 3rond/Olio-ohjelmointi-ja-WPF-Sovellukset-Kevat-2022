using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            opsikelijat opiskelija1 = new opsikelijat("pekka", "12345", 0);
            opsikelijat opiskelija2 = new opsikelijat("erond", "22334", 2);
            {
                opiskelija1.tulostaData();
                opiskelija1.muokkaaopintopisteitä(20);
                opiskelija1.muokkaaopintopisteitä(15);

                opiskelija2.tulostaData();
                opiskelija2.muokkaaopintopisteitä(20);
                opiskelija2.muokkaaopintopisteitä(15);
            }
           

            
        }
    }
}
