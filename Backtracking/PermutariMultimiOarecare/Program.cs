using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutariMultimiOarecare
{
    class Program
    {
        static void bk(int[] v, int[] st, bool[] b, int k)
        {
            if(k>=st.Length)
            {
                for (int i = 0; i < st.Length; i++)
                    Console.Write(v[st[i]]+"\t");
                Console.WriteLine();

            }else
            {
                for(int i=0;i<v.Length;i++)
                    if(!b[i])
                {
                        st[k] = i;
                        b[i] = true;
                        bk(v, st, b, k + 1);
                        b[i] = false;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] v = new int[] { -6, 5, 2, 0,1,4,5,7 };
            int[] st = new int[v.Length];
            bool[] b = new bool[v.Length];
            bk(v, st, b, 0);
        }
    }
}
