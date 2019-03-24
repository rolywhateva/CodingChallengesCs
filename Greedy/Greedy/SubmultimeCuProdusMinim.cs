using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class SubmultimeCuProdusMinim
    {
        //Se da un vector cu n elemente. Sa se afiseze produsul  minim pe care il poate avea
        //o submultime
        static int sol1(int[] v)
        {
            Array.Sort(v);

            if (v[0] >= 0 ||v[0]==v[v.Length-1])

                return v[0];

            int countNeg = 0;
            for (int i = 0; i < v.Length; i++)
                if(v[i]<0)
                countNeg++;

            if (countNeg % 2 == 0)
                countNeg--;

            int p = 1, toDivide = 1;
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i]!=0)
                p = p * v[i];
                if (i == countNeg)
                    toDivide = v[i];

            }
            if (p > 0)
                p = p / toDivide;

            return p;            
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sol1(new int[] { -1, -1, -2, 4, 3 }));
            Console.WriteLine(sol1(new int[] { 0, -1 }));
            Console.WriteLine(sol1(new int[] { 1, 0 }));
            Console.WriteLine(sol1(new int[] { 3, 4, 2, 3 }));
            Console.WriteLine(sol1(new int[] { -3, -4, -2, -1, -1, 0 }));

        }
    }
}
