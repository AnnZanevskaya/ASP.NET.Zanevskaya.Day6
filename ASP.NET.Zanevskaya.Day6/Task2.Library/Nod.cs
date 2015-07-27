using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Task3.Library
{
    public class Nod
    {
        public static int FindNod(out long time, int firstN, int secondN)
        {
            return TimeRemaind(out time, () => NodEvklid(firstN, secondN));
        }
        public static int FindNod(out long time, int firstN, int secondN, int thirdN)
        {
            return TimeRemaind(out time, () => NodEvklid(firstN, secondN, thirdN));
        }
        public static int FindNod(out long time, params int[] arr)
        {
            return TimeRemaind(out time, () => NodEvklid(arr));
        }
        public static int FindBinNod(out long time, int firstN, int secondN)
        {
            return TimeRemaind(out time, () => BinaryNod(firstN, secondN));
        }
        public static int FindBinNod(out long time, int firstN, int secondN, int thirdN)
        {
            return TimeRemaind(out time, () => BinaryNod(firstN, secondN, thirdN));
        }
        public static int FindBinNod(out long time, params int[] arr)
        {
            return TimeRemaind(out time, () => BinaryNod(arr));
        }

        private static int TimeRemaind(out long time, Func<int> func)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int nod = func();
            time = stopwatch.ElapsedTicks;
            return nod;
        }
        private static int NodEvklid(int firstN, int secondN)
        {
            if (firstN == 0 || secondN == 0) return 0;
            if (firstN < 0 || secondN < 0)
            {
                firstN = Math.Abs(firstN);
                secondN = Math.Abs(secondN);
            }
            while (secondN > 0)
            {
                int temp = secondN;
                secondN = firstN % secondN;
                firstN = temp;
            }
            return firstN;
        }
        private static int NodEvklid(int firstN, int secondN, int thirdN)
        {
            int nodOfTwo = NodEvklid(firstN, secondN);
            return NodEvklid(nodOfTwo, thirdN);
        }
        private static int NodEvklid(params int[] arr)
        {
            int nod = NodEvklid(arr[0], arr[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                nod = NodEvklid(nod, arr[i]);
            }
            return nod;
        }
        private static int BinaryNod(int firstN, int secondN)
        {
            if (firstN == 0 || secondN == 0) return 0;
            if (firstN < 0 || secondN < 0)
            {
                firstN = Math.Abs(firstN);
                secondN = Math.Abs(secondN);
            }
            if (firstN == secondN) return firstN;
            if (firstN == 0) return secondN;
            if (secondN == 0) return firstN;
            if ((~firstN & 1) != 0)
            {
                if ((secondN & 1) != 0) return BinaryNod(firstN >> 1, secondN);
                else return BinaryNod(firstN >> 1, secondN >> 1) << 1;
            }
            if ((~secondN & 1) != 0) return BinaryNod(firstN, secondN >> 1);
            if (firstN > secondN) return BinaryNod((firstN - secondN) >> 1, secondN);
            return BinaryNod((secondN - firstN) >> 1, firstN);
        }
        private static int BinaryNod(int firstN, int secondN, int thirdN)
        {
            int nodOfTwo = BinaryNod(firstN, secondN);
            return BinaryNod(nodOfTwo, thirdN);
        }
        private static int BinaryNod(params int[] arr)
        {
            int nod = BinaryNod(arr[0], arr[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                nod = BinaryNod(nod, arr[i]);
            }
            return nod;
        }
    }
}
