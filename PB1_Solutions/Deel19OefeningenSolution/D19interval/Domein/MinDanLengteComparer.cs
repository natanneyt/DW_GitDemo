namespace D19interval.Domein
{
    internal class MinDanLengteComparer : IComparer<Interval>
    {
        public int Compare(Interval? x, Interval? y)
        {
            int vergelijking1 = x.Min.CompareTo(y.Min);
            if (vergelijking1 == 0) return x.Lengte.CompareTo(y.Lengte);
            else return vergelijking1;
        }
    }
}
