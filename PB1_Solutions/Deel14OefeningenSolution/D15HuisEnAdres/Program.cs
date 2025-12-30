namespace D15HuisEnAdres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Huis huis = new Huis(new Adres("Straat", 1));
            huis.DrukAdresAf();
        }
    }
}
