namespace D15cirkelpunt.Figuren
{
    internal class Cirkel
    {
        public Punt Middelpunt { get; set; }

        private double _straal = 0;

        public double Straal
        {
            get
            {
                return _straal;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Straal moet groter dan 0 zijn.");
                else _straal = value;
            }
        }

        public Cirkel(double x, double y, double straal)
        {
            Middelpunt = new Punt(x, y);
            Straal = straal;
        }

        public double BerekenOmtrek()
        {
            return Math.Round(2 * _straal * Math.PI, 2);
        }

        public double BerekenOppervlakte()
        {
            return Math.Round(Math.Pow(_straal, 2) * Math.PI, 2);
        }

        public void VerplaatsNaar(double x, double y)
        {
            Middelpunt = new Punt(x, y);
        }

        public bool Bevat(Punt p)
        {
            if (p.BerekenAfstandTussen(Middelpunt) <= Straal) return true;
            return false;
        }

        // D15cirkeloverlapt
        public bool Overlapt(Cirkel cirkel)
        {
            if (Middelpunt.BerekenAfstandTussen(cirkel.Middelpunt) < Straal + cirkel.Straal) return true;
            return false;
        }
    }
}
