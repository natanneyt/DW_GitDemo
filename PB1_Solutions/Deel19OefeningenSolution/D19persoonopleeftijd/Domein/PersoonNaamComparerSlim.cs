namespace D19persoonopleeftijd.Domein
{
    internal class PersoonNaamComparerSlim : IComparer<Persoon>
    {
        private bool _isNormaleVolgorde = true;

        public PersoonNaamComparerSlim(bool isNormaleVolgorde)
        {
            _isNormaleVolgorde = isNormaleVolgorde;
        }

        public PersoonNaamComparerSlim() { }

        public int Compare(Persoon x, Persoon y)
        {
            if (_isNormaleVolgorde)
            {
                return x.Naam.CompareTo(y.Naam);
            }
            else return y.Naam.CompareTo(x.Naam);
        }
    }
}
