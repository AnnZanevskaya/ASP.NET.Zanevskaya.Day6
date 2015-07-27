using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Library;
using System.Diagnostics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           // int firstN = 1071;
            int firstN = 1071;
            int secondN = 81;
            int thirdN = 9;
            int fourth = 3;
            int more = 0;
            int expected = 0;
            long time;
            long btime;
           // int ner = Nod.FindNod(out time, firstN, secondN, thirdN);
            int ner2 = Nod.FindNod(out time, firstN, secondN, thirdN, fourth);
            int bin = Nod.FindBinNod(out btime, firstN, secondN, thirdN, fourth);
            Console.WriteLine("ner {0} {1} , {2}", ner2, time, btime);
            //int nod = Nod.NodEvklid(firstN, secondN);
           
            //Console.WriteLine("first number {0}, second number {1}, third {2},  nod {3} ", firstN, secondN,thirdN, nod);
            //Console.WriteLine("first number {0}, second number {1},  Nod {2}, {3}, {4}", firstN, secondN,thirdN,more, binaryNod);
        }
    }
}
