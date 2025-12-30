namespace D19afspraak.Domein
{
    internal class Afspraak
    {
        public DateTime Start { get; }

        public DateTime Einde { get; }

        public string Omschrijving { get; }

        public Afspraak(DateTime start, DateTime einde, string omschrijving)
        {
            Start = start;
            Einde = einde;
            Omschrijving = omschrijving;
        }

        public bool Overlapt(Afspraak afspraak)
        {
            return (Start < afspraak.Einde && Einde > afspraak.Start) || (afspraak.Start < Einde && afspraak.Einde > Start);
        }
    }
}
