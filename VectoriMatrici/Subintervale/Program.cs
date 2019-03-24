using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subintervale
{
    class Program
    {
        //Se considera un sir din Z^n si un m din Z. Sa se imparta vectorul in m subintervale deschise de
        // lungimi egale
        //si sa se specifice   pentru fiecare  cate valori din vectori apartin  acelui interval.
        static int[] sol(int[] a, int m)
        {
            Array.Sort(a);
            int min = a[0], max = a[a.Length - 1];
            Console.WriteLine(min + " " + max);
            int lgInterval = (max - min) / m;
            int i , capat = min + lgInterval, inceput = min, nr, contor;
            i = nr = contor = 0;
            int[] rez = new int[m];
            while (a[i] == min)
                i++;
            Console.WriteLine(a[i]);
            while(i<a.Length&&contor<m)
            {
                Console.WriteLine("*");
                if (inceput<a[i]&&a[i]<capat)
                    nr++;
                else
                {
                    rez[contor++] = nr;
                    nr = 0;
                    inceput = capat;
                    capat += lgInterval;
                }
                i++;
            }
            return rez;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 9, 4, 3, 4, 1, 6, 7, 8, 9, 5, 5, 4 };
            int[] rez = sol(a, 2);
            Console.WriteLine("({0})", string.Join(",", rez));
             rez = sol(a, 3);
            Console.WriteLine("({0})", string.Join(",", rez));

            Console.ReadKey();

        }
    }
}
