using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutari3
{
    class Program
    {
        static void bk(int n,int k, int[] s,bool[] b)
        {
            if(k>=n)
            {
                for(int i=0;i<s.Length;i++)
                    Console.Write(s[i]+"\t");
                Console.WriteLine();
            }else
            {
                for(int i=0;i<n;i++)
                    if(!((i+1)%2==0&&k+1!=i+1)&&!b[i])
                    {
                        s[k] = i + 1;
                        b[i] = true;
                        bk(n, k + 1, s, b);
                        b[i] = false;
                    }
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int k = 0;
            int[] s = new int[n];
            bool[] b = new bool[n];
            bk(n, k, s, b);
        }
    }
}
