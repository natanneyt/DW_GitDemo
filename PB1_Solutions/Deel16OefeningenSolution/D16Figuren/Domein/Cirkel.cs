namespace D16Figuren.Domein
{
    public class Cirkel : Figuur
    {
        public double Straal { get; set; }

        public Cirkel(double straal) : base()
        {
            Straal = straal;
        }

        public override double BerekenOppervlakte()
        {
            return Math.Pow(Straal,2) * Math.PI;
        }
    }
}
