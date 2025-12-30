namespace D19persoonopleeftijd.Domein
{
    internal class Persoon : IComparable<Persoon>
    {
        public string Naam { get; set; }

        public int Leeftijd { get; set; }

        public Persoon (string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{Naam}, {Leeftijd} jaar";
        }

        public int CompareTo(Persoon other)
        {
            Console.WriteLine($"   {Naam} en {other.Naam} worden vergeleken");
            return Leeftijd.CompareTo(other.Leeftijd);
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType() == GetType())
            {
                Persoon anderePersoon = (Persoon)obj;
                return Leeftijd.Equals(anderePersoon.Leeftijd);
            }
            else throw new Exception();
        }

        public override int GetHashCode()
        {
            return Leeftijd.GetHashCode();
        }
    }
}
