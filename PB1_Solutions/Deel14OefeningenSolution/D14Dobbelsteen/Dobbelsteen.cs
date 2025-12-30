using System;
using System.Collections.Generic;
using System.Text;

namespace D14Dobbelsteen
{
    internal class Dobbelsteen
    {
        public int AantalOgen { get; set; }

        public void RolDobbelsteen()
        {
            Random random = new Random();
            AantalOgen = random.Next(1,7);
        }
    }
}
