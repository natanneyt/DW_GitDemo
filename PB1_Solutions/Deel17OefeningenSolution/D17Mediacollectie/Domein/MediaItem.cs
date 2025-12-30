namespace D17Mediacollectie.Domein
{
    abstract class MediaItem
    {
        public string Titel { get; set; }

        public int DuurInSeconden { get; set; }

        public MediaItem(string titel, int duurInSeconden)
        {
            Titel = titel;
            DuurInSeconden = duurInSeconden;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Titel} - {DuurInSeconden}";
        }
    }
}
