using Domein;
using System.Collections.Generic;

namespace Container_Oef
{
    public class SorteerOpMassaComparer : IComparer<Container>
    {
        public int Compare(Container container1, Container container2)
        {
            return container1.GetMassa() - container2.GetMassa();
        }
    }
}
