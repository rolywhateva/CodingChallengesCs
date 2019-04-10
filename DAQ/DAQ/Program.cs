using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ
{
    class Program
    {
        static int Search(int[] a, int st, int dr, int x)
        {
             if (st == dr)
                {
                    if (a[st] == x)
                        return 1;
                    else
                        return 0;

                }
                else
                {
                    int m = (st + dr) / 2;
                    return Search(a, st, m, x) + Search(a, m + 1, dr, x);
                }
            
          
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 3, 0, 3, 0, 3, 0, 3, 2, 1, 0, 3, 0, 3, 4, 5, 6, 7, 3 };
            Console.WriteLine(Search(a,0,a.Length-1,3));
        }
    }
}
