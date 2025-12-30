namespace D15cirkelpunt.Figuren
{
    internal class Punt
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Punt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double BerekenAfstandTussen(Punt punt)
        {
            return Math.Sqrt(Math.Pow(punt.X - X, 2) + Math.Pow(punt.Y - Y, 2));
        }
    }
}
