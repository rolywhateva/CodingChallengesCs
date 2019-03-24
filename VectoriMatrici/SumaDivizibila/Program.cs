using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDivizibila
{
    class Program
    {
        static int sol1(int[] a,int n)
        {
            int nr = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if ((a[i] + a[j]) % n == 0)
                        nr++;
            return nr;
                         
        }
        static int Comb(int n, int k)
        {
            int p = 1;
            for (int i = n; i >= n - k; i--)
                p *= i;
            if (n == 0) p = 1;
            int p1 = 1;
            for (int i = 1; i <= k; i++)
                p1 = p1 * i;
            return p / p1;
        }
        static int sol2(int[] a, int n)
        {
            int[] frec = new int[n];

            for (int i = 0; i < a.Length; i++)
                frec[a[i] % n]++;
            int s = 0;
            int half = frec.Length / 2 + frec.Length % 2;
            for (int i = 0; i <=half; i++)
                  s = s + frec[i] * frec[frec.Length - i - 1];

            
            if(n%2==0&&frec[n/2]>1)
                s = s + Comb(frec[n/2], 2);
            if (frec[0] > 1)
                s = s + Comb(frec[0], 2);
         
            return s;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 6, 8, 10 };
            Console.WriteLine(sol2(a, 4));
            Console.ReadKey();
        }
    }
}
