namespace D17Huisdierenregister.Domein
{
    internal class Hond : Huisdier
    {
        public string Ras { get; set; }

        public Hond(string naam, int leeftijd, string ras) : base(naam, leeftijd)
        {
            Ras = ras;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Naam} - {Leeftijd} - {Ras}";
        }
    }
}
