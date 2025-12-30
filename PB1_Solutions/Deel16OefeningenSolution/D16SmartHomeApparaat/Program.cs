using D16SmartHomeApparaat.Domein;

namespace D16SmartHomeApparaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome smartHome = new SmartHome();

            try
            {
                smartHome.VoegDeviceToe(new SmartLight("Device1", 10));
                smartHome.VoegDeviceToe(new SmartThermostaat("Device2", 10));
                smartHome.VoegDeviceToe(new SmartThermostaat("Device3", 29));
                smartHome.VoegDeviceToe(new SmartLight("Device4", 49));
                smartHome.VoegDeviceToe(new SmartLight("Device4", 140));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            smartHome.VoerAlleActiesUit();
        }
    }
}
