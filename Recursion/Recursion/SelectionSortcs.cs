using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class SelectionSortcs
    {
        static void Sort(int[] a, int i, int j, int index)
        {
            if(i<a.Length-1)
            {
                if(j<a.Length)
                {
                    if (a[j] > a[index])
                        index = j;
                    Sort(a, i, j + 1, index);
                }else
                {
                    int aux = a[i];
                    a[i] = a[index];
                    a[index] = aux;
                    Sort(a, i + 1, i + 1, i + 1);
                }
            }
        }
        static void Main()
        {
            int[] a = new int[] { -3, 2, 4, 5, -6, 1, -7, 8, 9, -10, -11, 2, 3, -23, -34 };
            Sort(a, 0,1,0);
            Console.WriteLine(string.Join(" ", a));


        }
    }
}
