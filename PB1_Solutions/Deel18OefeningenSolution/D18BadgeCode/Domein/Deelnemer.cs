namespace D18Badgecode.Domein
{
    internal class Deelnemer : IComparable<Deelnemer>
    {
        public string Naam { get; set; }

        public string Badgecode { get; set; }

        public Deelnemer(string naam, string badgecode)
        {
            Naam = naam;
            Badgecode = badgecode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType().Name == GetType().Name)
            {
                Deelnemer other = (Deelnemer)obj;
                if (Badgecode.Equals(other.Badgecode)) return true;
                else return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Badgecode.GetHashCode();
        }

        public int CompareTo(Deelnemer? y)
        {
            return Badgecode.CompareTo(y.Badgecode);
        }
    }
}
