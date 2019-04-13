using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    /*
     * Se dă un șir cu n numere întregi. 
     * Determinați cel mai mare număr care poate fi scris ca
     * produs de două elemente ale șirului.
     * */
    class ProdusMaximPosibil
    {
        static  int ProdusMaxim(int[] a )
        {
            if (a.Length == 1)
                return a[0];
            int n = a.Length;
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                     if(a[i]<a[j])
                    {
                        int aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
            return Math.Max(a[0] * a[1], a[n - 1] * a[n - 2]);
        }
        static void Main()
        {
            Console.WriteLine(ProdusMaxim(new int[] { -3, 4, 2, 0, 5 }));
            Console.WriteLine(ProdusMaxim(new int[] {5,0,-3,-4 }));
            Console.WriteLine(ProdusMaxim(new int[] { -4 }));

            return;
        }
    }
}
