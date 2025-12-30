namespace D16SmartHomeSensorAlarm.Domein
{
    abstract class SmartDevice
    {
        public string Naam { get; set; }

        public SmartDevice(string naam)
        {
            Naam = naam;
        }

        public abstract void VoerActieUit();
    }
}
