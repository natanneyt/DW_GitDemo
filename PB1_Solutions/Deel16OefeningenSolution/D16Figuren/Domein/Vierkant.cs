namespace D16Figuren.Domein
{
    internal class Vierkant : Figuur
    {
        public double Lengte { get; set; }

        public Vierkant(double lengte) : base()
        {
            Lengte = lengte;
        }

        public override double BerekenOppervlakte()
        {
            return Math.Pow(Lengte, 2);
        }
    }
}
