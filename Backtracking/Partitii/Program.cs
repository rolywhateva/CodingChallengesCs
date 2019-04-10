using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitii
{
    class Program
    {
        static void bk(int n, int k, int[] s, bool[] b,int perm, int nrsol)
        {
            if(k>=n)
            {
                for(int i=0;i<perm;i++)
                {
                    bool exista = false;
                    for (int j = 0; j < s.Length; j++)
                        if (s[j] == i + 1)
                        {
                            Console.Write((j + 1) + "\t");
                            exista = true;
                        }
                      if(exista)
                        Console.WriteLine();
                    nrsol++;
             


                }
                Console.WriteLine();
                Console.WriteLine("-----------");
                if (nrsol % 10 == 0)
                    Console.ReadKey();
            }else
            {
                for(int i=0;i<n;i++)
                    if(k==0||(k>0&&Math.Abs(i+1-s[k-1])<=1&&!b[i]))
                {
                    s[k] = i + 1;
                    
                   b[k] = true;
                        if (s[k] > perm) perm = s[k];
                    bk(n, k+1, s, b,perm,nrsol);
                        b[i] = false;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 7;
            int k = 0;
            int[] s = new int[n];
            bool[] b = new bool[n];
            int nrsol = 0;

            bk(n, 0, s, b, 0,nrsol);
        }
    }
}
