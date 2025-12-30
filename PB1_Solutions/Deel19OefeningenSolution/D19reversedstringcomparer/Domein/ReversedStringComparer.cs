namespace D19reversedstringcomparer.Domein
{
    internal class ReversedStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return ReverseText(x).CompareTo(ReverseText(y));
        }

        static private string ReverseText(string text)
        {
            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }
    }
}
