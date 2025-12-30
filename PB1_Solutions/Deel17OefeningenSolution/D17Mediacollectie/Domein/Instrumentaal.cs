namespace D17Mediacollectie.Domein
{
    internal class Instrumentaal : MediaItem
    {
        public string Instrument { get; set; }

        public Instrumentaal(string titel, int duurInSeconden, string instrument) : base(titel, duurInSeconden)
        {
            Instrument = instrument;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Instrument}";
        }
    }
}
