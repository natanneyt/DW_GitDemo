namespace D18Teams.Domein
{
    internal class Speler : IComparable<Speler>
    {
        public string ID { get; set; }

        public string Naam { get; set; }

        public string Positie { get; set; }

        public Speler(string id, string naam, string positie)
        {
            ID = id;
            Naam = naam;
            Positie = positie;
        }

        public override bool Equals(object? obj)
        {
            if(obj != null && obj.GetType().Name == GetType().Name)
            {
                Speler andereSpeler = obj as Speler;
                return ID.Equals(andereSpeler.ID);
            }
            throw new ArgumentException("Fout object ingegeven.");
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public int CompareTo(Speler? other)
        {
            if (other != null && other.GetType().Name == GetType().Name)
            {
                Speler andereSpeler = other as Speler;
                return ID.CompareTo(andereSpeler.ID);
            }
            throw new ArgumentException("Fout object ingegeven.");
        }

        public override string ToString()
        {
            return $"{ID} - {Naam} ({Positie})";
        }
    }
}
