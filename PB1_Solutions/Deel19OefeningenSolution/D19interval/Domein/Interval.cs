namespace D19interval.Domein
{
    internal class Interval
    {
        public int Min { get; }

        public int Max { get; }

        public int Lengte { get { return Max - Min; } }

        public Interval(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public bool OverlaptMet(Interval anderInterval)
        {
            return (Min < anderInterval.Max && Max > anderInterval.Max) || (anderInterval.Min < Max && anderInterval.Max > Max);
        }
    }

}
