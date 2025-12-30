using D16VoertuigAutoMotorUitbreiding.Domein;

namespace D16VoertuigAutoMotorUitbreiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Voertuig> autos = new List<Voertuig>();
            autos.Add(new Auto(new DieselMotor()));
            autos.Add(new Auto(new BenzineMotor()));

            foreach(Auto auto in autos)
            {
                auto.Start();
            }
        }
    }
}
