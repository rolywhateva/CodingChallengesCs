using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class BubbleSort
    {
        static void Sort(int[] a, int i, bool sorted)
        {
            if (i < a.Length - 1)
            {
                if (a[i] < a[i + 1])
                {
                    int aux = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = aux;
                    sorted = false;
                }
                Sort(a, i + 1, sorted);
            }
            else
                 if (sorted)
                return;
            else
                Sort(a, 0, true);

        }
        static void Main(string[] args)
        {
            int[] a = new int[] { -3, 2, 4, 5, -6, 1, -7, 8, 9, -10, -11, 2, 3, -23, -34 };
            Sort(a, 0, true);
            Console.WriteLine(string.Join(" ",a));

        }
    }
}
