using System;
using System.Collections.Generic;
using System.Text;

namespace D19printmetopmaak.Domein
{
    internal class AllCapsStyle : IStyle
    {
        public string GetStyledTextFor(string text)
        {
            return text.ToUpper();
        }
    }
}
