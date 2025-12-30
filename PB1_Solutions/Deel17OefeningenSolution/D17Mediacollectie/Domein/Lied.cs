namespace D17Mediacollectie.Domein
{
    internal class Lied : MediaItem
    {
        public string Zanger { get; set; }

        public Lied(string titel, int duurInSeconden, string zanger) : base(titel, duurInSeconden)
        {
            Zanger = zanger;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Zanger}";
        }
    }
}
