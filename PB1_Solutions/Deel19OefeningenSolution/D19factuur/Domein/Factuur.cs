namespace D19factuur.Domein
{
    internal class Factuur
    {
        public bool Betaald { get; set; } = false;

        public DateTime Vervaldatum { get; }

        public decimal Bedrag { get; }

        public Factuur(decimal bedrag, DateTime vervaldatum)
        {
            Bedrag = bedrag;
            Vervaldatum = vervaldatum;
        }

        public bool IsAchterstallig(DateTime datum)
        {
            if (!Betaald && Vervaldatum < datum)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return $"Betaald: {Betaald}, {Vervaldatum.ToString()}, {Bedrag}, is achterstallig: {IsAchterstallig(new DateTime(2021, 1, 11))}";
        }
    }
}
