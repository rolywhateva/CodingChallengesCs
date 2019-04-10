using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class KChanges
    {
        /*
         * https://www.geeksforgeeks.org/maximize-array-sun-after-k-negation-operations/
         * */
        static int Sum(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
                s = s + a[i];
            return s;
        }
        static int  Sol1(int[] a, int k)
        {
            Array.Sort(a);
            if(a[0]>=0)
            {
                a[0] *= (int)Math.Pow(-1, k);
                return Sum(a);
            }
            int i = 0;
            while(a[i]<0&&i+1<k)
            {
                a[i] *= -1;
                i++;
            }
            if (i+1 < k && a[i] > 0)
                a[i] = a[i] * (int)Math.Pow(-1, k - i);
            return Sum(a);

        }
        static void Main()
        {
            Console.WriteLine(Sol1(new int[] { 0, 3, 4 },3));
            Console.WriteLine(Sol1(new int[] {1,2,4 },3));
            Console.WriteLine(Sol1(new int[] {-5,2,3,-4 },2));
            Console.WriteLine(Sol1(new int[] { -5, 2, 3,0, -4 }, 3));
            Console.WriteLine(Sol1(new int[] { -5, 2, 3, 1, -4 }, 5));
        }
    }
}
