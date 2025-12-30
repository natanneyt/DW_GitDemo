using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16VoertuigAutoMotor.Domein
{
    internal class Motor
    {
        private double _vermogen;
        public double Vermogen
        {
            get
            {
                return _vermogen;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Het vermogen moet positief zijn.");
                else _vermogen = value;
            }
        }

        public void StartMotor()
        {
            Console.WriteLine("De motor wordt gestart.");
        }
    }
}
