namespace D14artikel
{
    internal class Artikel
    {
        private double _prijsExclBTW;
        private double _btwPercentage;

        public double BtwPercentage
        {
            get
            {
                return _btwPercentage;
            }
            init
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Het BTW-percentage mag niet negatief zijn.");
                else _btwPercentage = value;
            }
        }
        public double PrijsExclBTW
        {
            get
            {
                return _prijsExclBTW;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("De prijs mag niet negatief zijn.");
                else _prijsExclBTW = value;
            }
        }

        public Artikel(double prijsExclBTW) : this(prijsExclBTW, 21) { }

        public Artikel(double prijsExclBTW, double btwPercentage)
        {
            PrijsExclBTW = prijsExclBTW;
            BtwPercentage = btwPercentage;
        }

        public double BerekenBTW()
        {
            return Math.Round(PrijsExclBTW * BtwPercentage / 100,2);
        }

        public double BerekenPrijsInclBTW()
        {
            return PrijsExclBTW + BerekenBTW();
        }
    }
}
