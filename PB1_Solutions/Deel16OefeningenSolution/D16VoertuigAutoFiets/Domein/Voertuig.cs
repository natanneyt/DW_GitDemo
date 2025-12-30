namespace D16VoertuigAutoFiets.Domein
{
    abstract class Voertuig
    {

        public string Merk { get; set; }

        public Voertuig(string merk) 
        {
            Merk = merk;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Merk} start. Dit is een {GetType().Name}");
        }
    }
}
