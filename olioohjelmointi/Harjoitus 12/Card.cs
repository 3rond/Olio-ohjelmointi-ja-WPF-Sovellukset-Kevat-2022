using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_12
{
    class Card
    {
        protected Suits suit;
        protected string cardvalue;
        public Card()
        {
        }
        public Card(Suits suit2, string cardvalue2)
        {
            suit = suit2;
            cardvalue = cardvalue2;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", cardvalue, suit);
        }
    }
}
