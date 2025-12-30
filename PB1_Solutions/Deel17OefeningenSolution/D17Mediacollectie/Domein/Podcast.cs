namespace D17Mediacollectie.Domein
{
    internal class Podcast : MediaItem
    {
        public string Host { get; set; }

        public Podcast(string titel, int duurInSeconden, string host) : base(titel, duurInSeconden)
        {
            Host = host;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Host}";
        }
    }
}
