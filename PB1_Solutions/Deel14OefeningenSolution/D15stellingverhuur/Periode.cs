namespace D14stellingverhuur
{
    internal class Periode
    {
        public DateTime Start { get; set; }

        public DateTime Eind { get; set; }

        public Periode(DateTime start, DateTime eind)
        {
            Start = start;
            Eind = eind;
        }

        public int AantalUur()
        {
            return (int)Math.Round((Eind - Start).TotalHours, 0, MidpointRounding.AwayFromZero);
        }
    }
}
