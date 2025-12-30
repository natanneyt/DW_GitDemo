namespace D16VoertuigAutoMotorUitbreiding.Domein
{
    abstract class Voertuig
    {
        public string Merk { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("De auto start.");
        }
    }
}
