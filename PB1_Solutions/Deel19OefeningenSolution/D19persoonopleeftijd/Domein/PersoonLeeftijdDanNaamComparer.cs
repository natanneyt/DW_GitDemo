namespace D19persoonopleeftijd.Domein
{
    internal class PersoonLeeftijdDanNaamComparer : IComparer<Persoon>
    {

        public int Compare(Persoon x, Persoon y)
        {
            int vergelijking1 = x.Leeftijd.CompareTo(y.Leeftijd);
            return vergelijking1 != 0 ? vergelijking1 : x.Naam.CompareTo(y.Naam);
        }
    }
}
