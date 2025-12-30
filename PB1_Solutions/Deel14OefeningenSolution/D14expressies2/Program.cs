namespace D14expressies2
{
    class Persoon
    {
        public bool Vip { get; set; }
        public string Naam { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // v is een bool
            // Vip maakt deel uit van de Persoon-klasse en is een bool
            // bool = bool => dit is toegelaten
            bool v = (new Persoon()).Vip;
        }
    }
}
