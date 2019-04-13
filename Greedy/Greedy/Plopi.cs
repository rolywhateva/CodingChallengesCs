using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class Plopi
    {
        /**
         * 
         * https://www.pbinfo.ro/?pagina=probleme&id=398
         * */
        static int[] AflaPlopi(int[] a, out  int poz,out int  s)
        {
            poz = s = 0;
            int min = a[0];
            int n = a.Length;
            for (int i = 1; i < n; i++)
                if (a[i] <= min)
                    min = a[i];
                else
                {
                    s += a[i] - min;
                    a[i] = min;
                    poz++;
                }
            return a;
        }
        static void Main()
        {
            int poz, s;
            int[] a = new int[] {7,5,6,4,3,2,1,2};
            int[] rez = AflaPlopi(a, out poz, out s);
            Console.WriteLine("({0})-poz:{1}-s:{2}",string.Join(",",rez),poz,s);

            return;
        }
    }
}
