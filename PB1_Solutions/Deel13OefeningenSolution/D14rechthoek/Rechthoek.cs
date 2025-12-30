namespace D14rechthoek
{
    internal class Rechthoek
    {
        public double Hoogte { get; set; }

        public double Breedte {  get; set; }

        public double Oppervlakte { get { return Hoogte * Breedte; } }

        public Rechthoek(double hoogte, double breedte)
        {
            Hoogte = hoogte;
            Breedte = breedte;
        }
    }
}
