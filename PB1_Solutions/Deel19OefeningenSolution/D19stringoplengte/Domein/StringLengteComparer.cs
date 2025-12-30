namespace D19stringoplengte.Domein
{
    internal class StringLengteComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
