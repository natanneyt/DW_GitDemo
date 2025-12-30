namespace D16VoertuigAutoFiets.Domein
{
    internal class Auto : Voertuig
    {
        public Auto(string merk) : base(merk) { }

        public override void Start()
        {
            Console.WriteLine("De bestuurder geeft gas.");
            base.Start();
        }
    }
}
