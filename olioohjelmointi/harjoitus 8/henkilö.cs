﻿using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_8
{
   abstract class henkilö
    {
        public abstract string Nimi { get; set; }
        public abstract string Työpaikka { get; set; }
        public abstract int Palkka { get; set; }

        
        public void NäytäTiedot()
        {
            Console.WriteLine("nimi : " + Nimi +" työpaikka " + Työpaikka + " palkka " + Palkka);
        }

    }
}
