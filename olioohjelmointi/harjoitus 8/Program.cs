using System;

namespace harjoitus_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            pomo pomo1 = new pomo("Jari", "rehtori", 3000,500,"bmw");
            työntekijö työntekijä1 = new työntekijö("lassi", "opettaja", 2000, 76);
            
            
            pomo1.pomontiedot();
            työntekijä1.työntekijätiedot();
            pomo1.hei();

        }
    }
}
