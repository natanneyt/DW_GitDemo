using D16Dieren.Domein;

namespace D16Dieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>();

            dieren.Add(new Duif("Pieter",3452));
            dieren.Add(new Kat("Jan"));
            dieren.Add(new Duif("Geert", 2));

            foreach(Dier dier in dieren)
            {
                dier.GeefInfo();
            }
        }
    }
}
