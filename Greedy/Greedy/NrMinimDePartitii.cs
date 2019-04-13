using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class NrMinimDePartitii
    {
        static int NrPartitiiSlow(int[] a)
        {
            int n = a.Length;
            int[] partitii = new int[n];
            int nr = 0;
            //partitii[0] = a[0];
            for(int i=1;i<n;i++)
            {
                bool gasit = false;
                for(int j=0;j<nr&&!gasit;j++)
                     if(partitii[j]<a[i])
                    {
                        gasit = true;
                        partitii[j] = a[i];
                    }
                if(!gasit)
                {
                    partitii[nr] = a[i];
                    nr++;
                }
            }
            return nr;
        }
        static void Main()
        {
            int[] a = new int[] { 4, 6, 2, 5, 8, 1, 3, 7 };
            Console.WriteLine(NrPartitiiSlow(a));
        }
        
    }
}
