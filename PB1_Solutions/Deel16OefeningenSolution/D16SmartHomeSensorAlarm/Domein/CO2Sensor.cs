namespace D16SmartHomeSensorAlarm.Domein
{
    internal class CO2Sensor : SmartSensor
    {
        public CO2Sensor(string naam) : base(naam) { }

        public override void Meet()
        {
            Random random = new Random();
            Waarde = random.Next(0, 100);
        }
    }
}
