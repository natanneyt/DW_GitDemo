namespace D16Figuren.Domein
{
    internal class Driehoek : Figuur
    {
        public double Basis { get; set; }

        public double Hoogte { get; set; }

        public Driehoek(double basis, double hoogte) : base()
        {
            Basis = basis;
            Hoogte = hoogte;
        }

        public override double BerekenOppervlakte()
        {
            return (Basis * Hoogte) / 2;
        }
    }
}
