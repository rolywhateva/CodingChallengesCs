using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    class Program
    {
         static void Back(string s, int k, bool[] b, int[] c)
        {
            if(k>=s.Length)
            {
                for(int i=0;i<c.Length;i++)
                     if(b[i])
                    Console.Write(s[c[i]]);
                Console.WriteLine();
            } else
            {
                for(int i=0;i<s.Length;i++)
                    if(!b[i])
                {
                   
                    c[k] = i;
                    b[i] = true;
                    Back(s, k + 1, b, c);
                    b[i] = false;

                }
            }
        }
        static void Main(string[] args)
        {
            string s = "pan";
            int[] c = new int[s.Length];
            bool[] b = new bool[s.Length];
            Back(s, 0, b, c);
        }
    }
}
