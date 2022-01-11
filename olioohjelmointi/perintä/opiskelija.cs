using System;
using System.Collections.Generic;
using System.Text;

namespace perintä
{
    class opiskelija : henkilö
    {
        public int opiskelijaID;
        public string koulu;

        public opiskelija(string nimi, int ikä, int henkilötunnus, int _opsikelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opsikelijaID;
            koulu = _koulu;
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
