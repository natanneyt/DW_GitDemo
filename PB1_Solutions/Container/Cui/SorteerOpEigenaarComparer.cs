using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Domein;

namespace Container_Oef
{
    internal class SorteerOpEigenaarComparer : IComparer<Container>
    {
        public int Compare(Container container1, Container container2)
        {
            return container1.GetEigenaar().CompareTo(container2.GetEigenaar());
        }
    }
}
