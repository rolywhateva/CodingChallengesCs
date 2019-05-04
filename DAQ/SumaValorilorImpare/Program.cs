using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaValorilorImpare
{
    class Program
    {
        static int Sum(int[] a, int st, int dr)
        {
            if(st==dr)
            {
                if (a[st] % 2 != 0)
                    return a[st];
                else
                    return 0;
            }else
            {
                int m = (st + dr) / 2;
                int sst = Sum(a, st, m);
                int sdr = Sum(a, m + 1, dr);
                return sst + sdr;
            }
        
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 1, 3 };
            Console.WriteLine(Sum(a,0,a.Length-1));
        }
    }
}
