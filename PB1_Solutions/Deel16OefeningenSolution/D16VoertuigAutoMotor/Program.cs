using D16VoertuigAutoMotor.Domein;

namespace D16VoertuigAutoMotor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voertuig auto = new Auto(new Motor());
            auto.Start();
        }
    }
}
