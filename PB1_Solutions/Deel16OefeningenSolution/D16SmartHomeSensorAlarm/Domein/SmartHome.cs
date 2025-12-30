namespace D16SmartHomeSensorAlarm.Domein
{
    internal class SmartHome
    {
        public List<SmartDevice> Devices { get; set; } = new List<SmartDevice>();

        public void VoegDeviceToe(SmartDevice device)
        {
            Devices.Add(device);
        }

        public void VoerAlleActiesUit()
        {
            foreach (SmartDevice device in Devices)
            {
                device.VoerActieUit();
            }
        }
    }
}
