using System;

namespace harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            koira.KuinkaMonta();
            Eläin.KuinkaMonta();
            kissa.KuinkaMonta();
            
            koira koira1 = new koira("mopsi", 4);
            koira koira2 = new koira("saksapaimekoira", 5);
            kissa kissa1 = new kissa("valkoinen", 3);
            kissa kissa2 = new kissa("oranssi", 5);
            Console.WriteLine("");
            koira.KuinkaMonta();
            Eläin.KuinkaMonta();
            kissa.KuinkaMonta();
        }
    }
}
