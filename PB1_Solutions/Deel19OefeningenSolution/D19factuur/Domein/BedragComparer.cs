namespace D19factuur.Domein
{
    internal class BedragComparer : IComparer<Factuur>
    {
        public int Compare(Factuur? x, Factuur? y)
        {
            return y.Bedrag.CompareTo(x.Bedrag);
        }
    }
}
