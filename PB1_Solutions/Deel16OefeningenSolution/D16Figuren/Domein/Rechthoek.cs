namespace D16Figuren.Domein
{
    public class Rechthoek : Figuur
    {
        public double Breedte { get; set; }

        public double Hoogte { get; set; }

        public Rechthoek(double breedte, double hoogte) : base() 
        {
            Breedte = breedte;
            Hoogte = hoogte;
        }

        public override double BerekenOppervlakte()
        {
            return Breedte * Hoogte;
        }
    }
}
