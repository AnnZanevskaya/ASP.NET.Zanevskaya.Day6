using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public class MaxValueAbsFinderAsc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MaxEl(firstA) < MaxEl(secondA))
                {
                    return -1;
                }
                if (MaxEl(firstA) > MaxEl(secondA))
                {
                    return 1;
                }
                return 0;
            }
            private static int MaxEl(int[] arr)
            {
                //try
                int maxEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    maxEl = Math.Max(maxEl, Math.Abs(arr[i]));
                }
                return maxEl;
                //catch (ArgumentNullException)
            }
        }
    public class MaxValueAbsFinderDesc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MaxEl(firstA) < MaxEl(secondA))
                {
                    return 1;
                }
                if (MaxEl(firstA) > MaxEl(secondA))
                {
                    return -1;
                }
                return 0;
            }
            private static int MaxEl(int[] arr)
            {
                //try
                int maxEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    maxEl = Math.Max(maxEl, Math.Abs(arr[i]));
                }
                return maxEl;
                //catch (ArgumentNullException)
            }
        }
    public class MinValueAbsFinderAsc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MinEl(firstA) < MinEl(secondA))
                {
                    return -1;
                }
                if (MinEl(firstA) > MinEl(secondA))
                {
                    return 1;
                }
                return 0;
            }
            private static int MinEl(int[] arr)
            {
                int minEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    minEl = Math.Min(minEl, Math.Abs(arr[i]));
                }
                return minEl;
            }
        }
    public class MinValueAbsFinderDesc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MinEl(firstA) < MinEl(secondA))
                {
                    return 1;
                }
                if (MinEl(firstA) > MinEl(secondA))
                {
                    return -1;
                }
                return 0;
            }
            private static int MinEl(int[] arr)
            {
                int minEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    minEl = Math.Min(minEl, Math.Abs(arr[i]));
                }
                return minEl;
            }
        }

    public class SumValueFinderAsc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (SumValue(firstA) < SumValue(secondA))
                {
                    return -1;
                }
                if (SumValue(firstA) > SumValue(secondA))
                {
                    return 1;
                }
                return 0;
            }
            private static int SumValue(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
    public class SumValueFinderDesc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (SumValue(firstA) < SumValue(secondA))
                {
                    return 1;
                }
                if (SumValue(firstA) > SumValue(secondA))
                {
                    return -1;
                }
                return 0;
            }
            private static int SumValue(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
    public class MultValueFinderAsc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MultValue(firstA) < MultValue(secondA))
                {
                    return -1;
                }
                if (MultValue(firstA) > MultValue(secondA))
                {
                    return 1;
                }
                return 0;
            }
            private static int MultValue(int[] arr)
            {
                int mult = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    mult *= arr[i];
                }
                return mult;
            }
        }
    public class MultValueFinderDesc : ICompare<int[]>
        {
            public int Compare(int[] firstA, int[] secondA)
            {
                if (MultValue(firstA) < MultValue(secondA))
                {
                    return 1;
                }
                if (MultValue(firstA) > MultValue(secondA))
                {
                    return -1;
                }
                return 0;
            }
            private static int MultValue(int[] arr)
            {
                int mult = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    mult *= arr[i];
                }
                return mult;
            }
        } 
}
