namespace D14cirkel
{
    internal class Cirkel
    {
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

        public Cirkel(double straal)
        {
            Straal = straal;
        }

        public double BerekenOmtrek()
        {
            return Math.Round(2 * _straal * Math.PI, 2);
        }

        public double BerekenOppervlakte()
        {
            return Math.Round(Math.Pow(_straal, 2) * Math.PI,2);
        }
    }
}
