namespace D19printmetopmaak.Domein
{
    internal class ExclamationStyle : IStyle
    {
        public string GetStyledTextFor(string text)
        {
            string tekst = "";
            foreach(char character in text)
            {
                if (character == '.') tekst += "!";
                else tekst += character;
            }
            return tekst;
        }
    }
}
