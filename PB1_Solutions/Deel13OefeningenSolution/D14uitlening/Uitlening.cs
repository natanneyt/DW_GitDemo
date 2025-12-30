namespace D14uitlening
{
    internal class Uitlening
    {
        public string Omschrijving { get; set; }

        public DateTime OntleenDatum { get; set; }

        public DateTime UitersteInleverdatum()
        {
            return OntleenDatum.AddDays(14);
        }
    }
}
