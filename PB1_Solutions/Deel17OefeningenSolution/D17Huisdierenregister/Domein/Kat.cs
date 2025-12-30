namespace D17Huisdierenregister.Domein
{
    internal class Kat : Huisdier
    {
        public bool IsBinnenkat { get; set; }

        public Kat(string naam, int leeftijd, bool isBinnenkat) : base(naam, leeftijd)
        {
            IsBinnenkat = isBinnenkat;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Naam} - {Leeftijd} - binnenkat: {IsBinnenkat}";
        }
    }
}
