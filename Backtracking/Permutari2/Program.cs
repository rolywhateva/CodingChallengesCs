using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutari2
{
    class Program
    {
        static void back(int n, int k, int[] s, bool[] b, int v)
        {
            if(k>=n)
            {
                for (int i = 0; i < s.Length; i++)
                    Console.Write(s[i]+" ");
                Console.WriteLine();
            }else
            {
                for(int i=0;i<n;i++)
                {
                    if(k==0||(k>0&&Math.Abs(i+1-s[k-1])>=v)&&!b[i])
                    {
                        s[k] = i + 1;
                        b[i] = true;
                        back(n, k + 1, s, b, v);
                        b[i] = false;

                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int k = 0;
            int[] s = new int[n];
            bool[] b = new bool[n];
            int v = 2;
            back(n, k, s, b, v);

        }
    }
}
