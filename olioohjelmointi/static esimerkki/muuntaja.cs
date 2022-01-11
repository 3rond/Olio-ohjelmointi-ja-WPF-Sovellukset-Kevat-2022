using System;
using System.Collections.Generic;
using System.Text;

namespace static_esimerkki
{
    static class muuntaja
    {
        public static float KmToMiles(float km)
        {
            float mailiArvo = 0.62137f;
            return km * mailiArvo;
        }
    }
}
