namespace D14auto
{
    internal class Auto
    {
        public string Kleur { get; set; }

        public string Nummerplaat { get; set; }

        public string Merk {  get; set; }

        public double HuidigeSnelheid { get; set; }

        // 4de parameter

        public Auto(string kleur, string merk)
        {
            Kleur = kleur;
            Merk = merk;
            Nummerplaat = "onbekend";
        }

        public Auto(string kleur) : this(kleur, "onbekend") { }

        public Auto() : this("grijs") { }

        public void Versnel(double waarde)
        {
            Math.Clamp(HuidigeSnelheid += waarde,0,220);
        }
    }
}
