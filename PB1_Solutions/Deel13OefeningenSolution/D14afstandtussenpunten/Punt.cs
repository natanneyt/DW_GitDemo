namespace D14afstandtussenpunten
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
            return Math.Sqrt(Math.Pow(punt.X - this.X,2) + Math.Pow(punt.Y - this.Y,2));
        }
    }
}
