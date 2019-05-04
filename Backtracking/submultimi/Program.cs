using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace submultimi
{
    class Program
    {
        static void bk(int[] st, int n, int k)
        {
            if (k > 0)
            {
                for (int i = 1; i < k; i++)
                    Console.Write(st[i]+"\t");
                Console.WriteLine();
            }
            for(int i=st[k-1]+1;i<=n;i++)
            {
                   st[k] = i;
                    bk(st, n, k + 1);
            }

        }
        static void Main(string[] args)
        {
            int n = 4;
            bool[] b = new bool[n];
            int[] st = new int[n + 1];
            bk(st, n, 1);
        }
    }
}
