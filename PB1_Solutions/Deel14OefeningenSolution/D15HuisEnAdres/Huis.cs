namespace D15HuisEnAdres
{
    internal class Huis
    {
        public Adres Adres { get; set; }

        public Huis(Adres adres)
        {
            Adres = adres;
        }

        public void DrukAdresAf()
        {
            Console.WriteLine(Adres.ToString());
        }
    }
}
