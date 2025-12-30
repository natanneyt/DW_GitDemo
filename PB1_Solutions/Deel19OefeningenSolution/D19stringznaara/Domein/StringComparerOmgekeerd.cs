using System;
using System.Collections.Generic;
using System.Text;

namespace D19stringznaara.Domein
{
    internal class StringComparerOmgekeerd : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y.CompareTo(x);
        }
    }
}
