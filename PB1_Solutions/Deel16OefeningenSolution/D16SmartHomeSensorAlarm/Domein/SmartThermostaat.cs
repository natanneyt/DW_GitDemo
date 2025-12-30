namespace D16SmartHomeSensorAlarm.Domein
{
    internal class SmartThermostaat : SmartDevice
    {
        private double _temperatuur;

        public double Temperatuur
        {
            get
            {
                return _temperatuur;
            }
            set
            {
                if (value < 10 || value > 30) throw new ArgumentOutOfRangeException("De temperatuur moet binnen het bereik [10, 30] liggen.");
                else _temperatuur = value;
            }
        }

        public SmartThermostaat(string naam, double temperatuur) : base(naam)
        {
            Temperatuur = temperatuur;
        }

        public SmartThermostaat(string naam) : base(naam) { }

        public override void VoerActieUit()
        {
            Console.WriteLine($"De temperatuur is {Temperatuur}.");
        }
    }
}
