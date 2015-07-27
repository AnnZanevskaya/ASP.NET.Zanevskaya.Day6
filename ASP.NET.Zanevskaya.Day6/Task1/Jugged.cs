using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2
{
    class Jugged
    {
        static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            ICompare<int[]> compar = new MaxValueAbsFinderAsc();
            JaggedSort.SortArrDel(jaggedArray, (a, b) => compar.Compare(a, b));

            ShowArrow(jaggedArray);
        }
        public static void ShowArrow(int[][] jagged)
        {
            int count = 0;
            foreach (int[] array in jagged)
            {
                Console.WriteLine("Mass {0}", count + 1);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" elements {0}", jagged[count][i]);
                }
                count++;
            }
        }
    }
}
