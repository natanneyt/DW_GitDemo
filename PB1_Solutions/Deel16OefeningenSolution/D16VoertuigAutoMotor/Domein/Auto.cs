using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16VoertuigAutoMotor.Domein
{
    internal class Auto : Voertuig
    {
        public Motor Motor { get; set; }

        public Auto(Motor motor)
        {
            Motor = motor;
        }

        public override void Start()
        {
            Console.WriteLine("De auto wordt gestart.");
            Motor.StartMotor();
        }
    }
}
