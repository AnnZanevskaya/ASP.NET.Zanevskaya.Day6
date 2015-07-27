using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public interface ICompare<T>
    {
        int Compare(int[] firstA, int[] secondA);
    }
}
