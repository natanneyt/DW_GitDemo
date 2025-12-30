namespace D14stellingverhuur
{
    internal class StellingVerhuring
    {
        public DateTime Startdatum { get; set; }

        public DateTime Einddatum { get; set; }

        public int AantalUurOpbouw { get; set; } = 8;

        public int AantalUurAfbraak { get; set; } = 4;

        public Levering Levering { get; set; }

        private const int PRIJSPERUUROPBOUW = 90;
        private const int PRIJSPERUURVERHUUR = 5;
        private const int PRIJSPERUURAFBRAAK = 60;
        private const int PRIJSPERKM = 10;

        public StellingVerhuring(DateTime startdatum, DateTime einddatum)
        {
            Startdatum = startdatum;
            Einddatum = einddatum;
        }

        public Periode NettoVerhuurPeriode()
        {
            return new Periode(Startdatum + TimeSpan.FromHours(AantalUurOpbouw), Einddatum - TimeSpan.FromHours(AantalUurAfbraak));
        }

        public decimal Prijs()
        {
            // . uren opbouw (90 per uur)         90 x   8 =  720
            // . netto uren verhuur (5 per uur)    5 x 741 = 3705
            // . uren afbraak (60 per uur)        60 x   4 =  240

            decimal prijs = AantalUurOpbouw * PRIJSPERUUROPBOUW
                + NettoVerhuurPeriode().AantalUur() * PRIJSPERUURVERHUUR
                + AantalUurAfbraak * PRIJSPERUURAFBRAAK;
            if (Levering != null) prijs += Levering.AfstandInKm * PRIJSPERKM;
            return prijs;
        }


    }
}
