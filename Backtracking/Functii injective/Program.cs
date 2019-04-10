using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii_injective
{
    class Program
    {
        static void bk(int nA, int nB, int k, int[] st, bool[] b)
        {
            if(k>=nA)
            {
                for (int i = 0; i < k; i++)
                    Console.WriteLine("f({0})={1}", i + 1, st[i]);
                Console.WriteLine("========");
                Console.WriteLine();
            }else
            {
                for(int i=0;i<nB;i++)
                    if(!b[i])
                {
                        st[k] = i+1;
                        b[i] = true;
                        bk(nA, nB, k + 1, st, b);
                        b[i] = false;
                }
            }
        }
        static void Main(string[] args)
        {
            int nA, nB;
            Console.WriteLine("nA=");
            nA = int.Parse(Console.ReadLine());
            Console.WriteLine("nB=");
            nB= int.Parse(Console.ReadLine());
            int[] st = new int[nA];
            bool[] b = new bool[nB];
            bk(nA, nB, 0, st, b);



        }
    }
}
