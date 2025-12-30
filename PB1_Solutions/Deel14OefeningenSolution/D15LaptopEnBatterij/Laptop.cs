using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15LaptopEnBatterij
{
    internal class Laptop
    {
        public Batterij Batterij { get; set; }

        public Laptop(Batterij batterij)
        {
            Batterij = batterij;
        }

        public int GeefLaadniveau()
        {
            return Batterij.Laadniveau;
        }
    }
}
