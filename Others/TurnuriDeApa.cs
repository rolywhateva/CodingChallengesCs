using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class TurnuriDeApa
    {
        static int Max(int[] a )
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        static int Pmax(int[] a )
        {
            int max = Max(a);
            for (int i = 0; i < a.Length; i++)
                if (a[i] == max)
                    return i;
            return 0;
        }
        static int Sol1(int[] a)
        {
            int max = 0;
            int s = 0;
            int litrii = 0;
            int nr = 0;
            int min = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] >= max)
                {

                    litrii += nr * max - s;
                    s = 0;
                    max = a[i];
                    nr = 0;
                }
                else
                {
                   s = s + a[i]; 
                    nr++;
                    min = a[i];
                }
            }
            if (s != 0)
                litrii += min * (nr - 1);
            return litrii;

         
                    


           

          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sol1(new int[] { 1, 0, 0, 2, 0, 0, 0, 3, 0, 0, 4, 0, 0, 3 }));
            Console.WriteLine(Sol1(new int[] { 4, 0, 2, 0, 1, 0, 2, 0, 3, 0, 3, 0, 4, 0, 1 }));
            Console.WriteLine(Sol1(new int[] { 0, 0, 0, 1, 0, 0, 0 }));
            Console.ReadKey();
        }
    }
}
