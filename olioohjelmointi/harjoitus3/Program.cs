using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas1 = new kiuas("harvia", 80 , 20);
            kiuas kiuas2 = new kiuas("tylö", 90, 10);
            kiuas kiuas3 = new kiuas("helo", 70, 30);

            kiuas1.näytätiedot();
            kiuas2.näytätiedot();
            kiuas3.näytätiedot();
        }
    }
}
