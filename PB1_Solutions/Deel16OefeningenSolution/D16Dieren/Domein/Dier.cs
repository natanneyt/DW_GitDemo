namespace D16Dieren.Domein
{
    abstract class Dier
    {
        public string Naam { get; set; }

        public Dier(string naam)
        {
            Naam = naam;
        }

        public virtual void GeefInfo()
        {
            Console.Write($"{GetType().Name}: {Naam}"); 
        }
    }
}
