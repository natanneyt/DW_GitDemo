namespace D17Huisdierenregister.Domein
{
    abstract class Huisdier
    {
        public string Naam { get; set; }

        public int Leeftijd { get; set; }

        public Huisdier(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Naam} - {Leeftijd}";
        }
    }
}
