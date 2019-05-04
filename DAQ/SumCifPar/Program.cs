using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCifPar
{
    class Program
    {
        static bool CifPar(int n)
        {
            if (n == 0)
                return false;
            int nr = 0;
            while(n!=0)
            {
                nr++;
                n = n / 10;
              
            }
            return nr % 2 == 0;
        }
        static bool DAC(int[] a, int st, int dr)
        {
            if (st == dr)
                return CifPar(a[st]);
            else
            {
                int m = (st + dr) / 2;
                return DAC(a, st, m) && DAC(a, m + 1, dr);
            }
        }
        static void Main(string[] args)
        {
            int[] v = new int[] { 12,23,4456,34,57,-78 };
            Console.WriteLine(DAC(v,0,v.Length-1));

        }
    }
}
