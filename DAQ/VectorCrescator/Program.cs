using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCrescator
{
    class Program
    {
        static bool Cresc(int[] a, int st, int dr)
        {
            if(st==dr)
            {
                if (st == 0 || st == a.Length - 1)
                    return true;
                else
                    return a[st] > a[st - 1];

            }else
            {
                int m = (st + dr) / 2;
                return Cresc(a, st, m) && Cresc(a, m + 1, dr);
            }
        }
        static void Main(string[] args)
        {
            int[] v = new int[] { 1, 3, 2, 4, 5, 7, 8 };
            Console.WriteLine(Cresc(v,0,v.Length-1));
            v = new int[] { -3, 4, 5, 6, 7, 8, 9, 12, 23, 56 };
            Console.WriteLine(Cresc(v, 0, v.Length - 1));

        }
    }
}
