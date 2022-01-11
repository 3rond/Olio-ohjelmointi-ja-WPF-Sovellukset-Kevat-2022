using System;
using System.Collections.Generic;
using System.Text;

namespace perintä
{
    class opiskelija : henkilö
    {
        public int opiskelijaID;
        public string koulu;

        private static int instanssit = 0;
        public opiskelija(string nimi, int ikä, int henkilötunnus, int _opsikelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opsikelijaID;
            koulu = _koulu;

            instanssit++;

        }
        public static void KuinkaMontaOpiskelijaa()
        {
            Console.WriteLine("opiskelijaa olemassa: " + instanssit);
        }

        //override ylilukee henkilö luokan "tulostustiedot metodin
        public override void Tulostatiedot()
        {
            Console.WriteLine("opsikelija: " + Nimi + " ikä " + Ikä + " koulu " + koulu + " opsikelijaID " + opiskelijaID);
        }

        public void opiskele()
        {
            Console.WriteLine(Nimi + "opiskelee");
        }
    }
}
