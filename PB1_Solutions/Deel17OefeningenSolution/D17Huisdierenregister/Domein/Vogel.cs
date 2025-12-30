namespace D17Huisdierenregister.Domein
{
    internal class Vogel : Huisdier
    {
        public bool KanPraten { get; set; }

        public Vogel(string naam, int leeftijd, bool kanPraten) : base(naam, leeftijd)
        {
            KanPraten = kanPraten;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Naam} - {Leeftijd} - spreekt: {KanPraten}";
        }
    }
}
