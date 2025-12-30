namespace D16SmartHomeApparaat.Domein
{
    internal class SmartLight : SmartDevice
    {
        private int _helderheid;
        
        public int Helderheid
        {
            get
            {
                return _helderheid;
            }
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException("De helderheid moet binnen het bereik [0, 100] liggen.");
                else _helderheid = value;
            }
        }
        public SmartLight(string naam, int helderheid) : base(naam)
        {
            Helderheid = helderheid;
        }

        public SmartLight(string naam) : base(naam) { }

        public override void VoerActieUit()
        {
            Console.WriteLine($"Het licht wordt aangezet op de volgende helderheid: {Helderheid}.");
        }
    }
}
