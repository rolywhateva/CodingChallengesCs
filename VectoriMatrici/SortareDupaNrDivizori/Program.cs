using System;
using System.IO;

namespace SortareDupaNrDivizori
{
    class Program
    {
       static int nrDivizori(int n)
        {
            int nr = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    nr++;
            return nr;
        }
        static int[] frecDivizori(int[] a)
        {
            int[] div = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                div[i] = nrDivizori(a[i]);
            return div;
        }
        static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static void Sort(int[] a, int[] div)
        {
            int n = a.Length;
            for(int i=0;i<n;i++)
                 for(int j=i+1;j<n;j++)
                     if(div[i]<div[j] ||(div[i]==div[j]&&a[i]>a[j]))
                    {
                        Swap(ref div[i], ref div[j]);
                        Swap(ref a[i], ref a[j]);
                    }
        }
        static void Main(string[] args)
        {
            int[] a, div;
            #region debug
            bool debug = false;

            if (debug)
            {
                 a = new int[]{ 12, 20, 4, 100, 13 };
             div = frecDivizori(a);
                Sort(a, div);
                Console.WriteLine("({0})", string.Join(",", a));
                return;
            }
            #endregion
            using (StreamReader sr = new StreamReader("../sortare_divizori.in"))
            {
                int n = int.Parse(sr.ReadLine());
                string[] lines = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );
                a = new int[n];
                for (int i = 0; i < a.Length; i++)
                    a[i] = int.Parse(lines[i]);
                div = frecDivizori(a);
                Sort(a, div);
                sr.Close();



            }
            using (StreamWriter sw = new StreamWriter("../sortare_divizori.out"))
            {
                sw.WriteLine(string.Join(" ", a));
                sw.Close();
            }




                Console.ReadKey();
            return;
        }
    }
}
