using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere1
{
    class Program
    {
        /**
         * Sa se genereze toate numerele naturale de n cifre care contin cel putin k cifre 1.
         * 
         * */
       static void bk(int[] st,int n,int k, int q, int unu)
        {
            if (k >= n)
            {
                if (unu ==q)
                {
                    for (int i = 0; i < k; i++)
                        Console.Write(st[i]);
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0 && k == 0)
                        st[k] = 1;
                    else
                        st[k] = i;
                    if (st[k] == 1)
                        bk(st, n, k + 1, q, unu + 1);
                    else
                        bk(st, n, k + 1, q, unu);


                }
            }
            
        }
        static void Main(string[] args)
        {
            int n = 3;
            int q = 2;
            int[] st = new int[n];
            bk(st, n, 0, q, 0);
          

        }
    }
}
