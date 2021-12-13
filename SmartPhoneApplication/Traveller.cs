using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApplication
{
    public class Traveller
    {
        public void Hike(IGps gps)
        {
            gps.Navigate();

        }
    }
}
