using System.Reflection.PortableExecutable;

namespace D19printmetopmaak.Domein
{
    internal class CapitalCasingStyle : IStyle
    {
        public string GetStyledTextFor(string text)
        {
            string newText = "";
            string upperCaseLetters = text.ToUpper();
            string lowercaseLetters = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0) newText += upperCaseLetters[i];
                else newText += lowercaseLetters[i];
            }
            return newText;
        }
    }
}
