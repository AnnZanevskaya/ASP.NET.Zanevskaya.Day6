using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public static class JaggedSort
    {
        public static void SortArr(int[][] jagged, ICompare<int[]> method)
        {
            if (jagged == null) throw new ArgumentNullException("jugged");        
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = i + 1; j < jagged.Length; j++)
                {
                    if (method.Compare(jagged[i], jagged[j]) > 0)
                    {
                        Swap(ref jagged[i], ref jagged[j]);
                    }
                }
            }
        }
        public static void SortArrDel(int[][] array, ICompare<int[]> comparer)
        {
            SortArrDel(array, (a, b) => comparer.Compare(a, b));
        }
        public static void SortArrDel(int[][] jagged, Func<int[],int[],int> comparison)
        {
            if (jagged == null) throw new ArgumentNullException("jugged");          
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = i + 1; j < jagged.Length; j++)
                {
                    if (comparison(jagged[i], jagged[j]) > 0)
                    {
                        Swap(ref jagged[i], ref jagged[j]);
                    }
                }
            }
        }
        private static void Swap(ref int[] firstArr, ref int[] secondArr)
        {
            int[] tempArr = firstArr;
            firstArr = secondArr;
            secondArr = tempArr;
        }
    }

}
