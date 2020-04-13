using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class HuileComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Huile h1 = (Huile)x;
            Huile h2 = (Huile)y;

            return h1.GetStock().CompareTo(h2.GetStock());
        }
    }
}
