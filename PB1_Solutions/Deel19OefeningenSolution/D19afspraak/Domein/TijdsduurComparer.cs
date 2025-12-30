namespace D19afspraak.Domein
{
    internal class TijdsduurComparer : IComparer<Afspraak>
    {
        public int Compare(Afspraak? x, Afspraak? y)
        {
            return (x.Einde - x.Start).CompareTo(y.Einde - y.Start);
        }
    }
}
