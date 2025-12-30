namespace D19persoonopleeftijd.Domein
{
    internal class PersoonNaamComparer : IComparer<Persoon>
    {
        private bool _alfabetisch = false;

        public int Compare(Persoon x, Persoon y)
        {
            Console.WriteLine($"   {x.Naam} en {y.Naam} worden vergeleken");

            // Wissel x en y om voor omgekeerde sortering.
            return x.Naam.CompareTo(y.Naam);
        }
    }
}
