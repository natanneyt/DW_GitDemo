using D16Figuren.Domein;

namespace D16Figuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figuur[] figuren = new Figuur[4];

            figuren[0] = new Cirkel(5);
            figuren[1] = new Driehoek(5, 5);
            figuren[2] = new Rechthoek(5, 5);
            figuren[3] = new Vierkant(10);

            foreach(Figuur figuur in figuren)
            {
                Console.WriteLine($"{figuur}, {figuur.BerekenOppervlakte()}");
            }
        }
    }
}
