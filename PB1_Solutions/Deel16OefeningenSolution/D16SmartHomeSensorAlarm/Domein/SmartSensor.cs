namespace D16SmartHomeSensorAlarm.Domein
{
    abstract class SmartSensor : SmartDevice
    {
        private double _waarde;

        public double Waarde
        {
            get
            {
                return _waarde;
            }
            set
            {
                if (value < 0) throw new ArgumentException("De waarde mag niet negatief zijn.");
                else _waarde = value;
            }
        }

        public SmartSensor(string naam) : base(naam) { }

        public override void VoerActieUit()
        {
            Meet();
            Console.WriteLine($"De gemeten waarde is {Waarde}.");
        }

        public abstract void Meet();
    }
}
