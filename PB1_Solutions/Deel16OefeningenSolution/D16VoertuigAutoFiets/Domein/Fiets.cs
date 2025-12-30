namespace D16VoertuigAutoFiets.Domein
{
    internal class Fiets : Voertuig
    {
        public Fiets(string merk) : base(merk) { }

        public override void Start()
        {
            Console.WriteLine("De fietser begint te trappen.");
            base.Start();
        }
    }
}
