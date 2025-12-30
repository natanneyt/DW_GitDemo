using D16VoertuigAutoFiets.Domein;

namespace D16VoertuigAutoFiets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voertuig[] voertuigen = new Voertuig[5];
            voertuigen[0] = new Auto("merk1");
            voertuigen[1] = new Fiets("merk2");
            voertuigen[2] = new Auto("merk3");
            voertuigen[3] = new Auto("merk4");
            voertuigen[4] = new Fiets("merk5");

            foreach(Voertuig voertuig in voertuigen)
            {
                voertuig.Start();
            }
        }
    }
}
