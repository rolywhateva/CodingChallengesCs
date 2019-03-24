using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VectoriMatrici
{
    class Program
    {
        /*
         * Se dau doua siruri de numere naturale,una este crescatoare iar 
         * cealalta descrescatoare.
         * Sa se afiseze valorile pare din ambele siruri in ordine crescatoare.
         * */
         static List<int> sol1(int[] a, int[] b)
        {
            int i = 0;
            int j = b.Length - 1;
            List<int> l = new List<int>();
            while(i<a.Length &&j>=0)
            {
                if (a[i] % 2 == 0 && b[j] % 2 == 0)
                {
                    if (a[i] < b[j]&&a[i]>=l[l.Count-1])
                    {
                        l.Add(a[i]);
                        l.Add(b[j]);
                    }
                    else
                    {
                        l.Add(b[j]);
                        l.Add(a[i]);
                    }
                    i++;
                    j--;

                }
                else
                     if (a[i] % 2 == 0)
                          j--;
                     else
                          i++;

            }
            while (i < a.Length)
            {
                Console.WriteLine("In ciclul i");
                if (a[i] % 2 == 0)
                    l.Add(a[i]);

                
                i++;
            }
            while (j >= 0)
            {
                
                if (b[j] % 2 == 0)
                    l.Add(b[j]);
                j--;

                
            }




            return l;
        }
        static List<int> sol2(int[] a, int[] b)
        {
            List<int> l = new List<int>();
            int i = 0;
            int j = b.Length - 1;
            while (i < a.Length && j >= 0)
            {
                if (a[i] < b[j])
                {
                    if (a[i] % 2 == 0)
                        l.Add(a[i]);
                    i++;
                }
                else
                {
                    if (b[j] % 2 == 0)
                        l.Add(b[j]);
                    j--;
                }
            }
            while(i<a.Length)
            {
                if (a[i] % 2 == 0)
                    l.Add(a[i]);
                i++;
            }
            while(j>=0)
            {
                if (b[j] % 2 == 0)
                    l.Add(b[j]);
                j--;
            }
            return l;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] {101,101,101,102,102,103,108,109};
            int[] b = new int[] {8,6,4,2,1,1,1,1,1,0};
            List<int> res = sol2(a, b);
            Console.WriteLine(string.Join(",", res));
            Console.ReadKey();
            return;
        }
    }
}
