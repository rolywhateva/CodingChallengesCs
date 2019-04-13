using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class PlatouPrime
    {

        static int nr, nrmax;
        static bool prim(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static  void  Pi(int[,] a,bool[,] b, int i, int j)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            if(i>=0&&j>=0&&i<n&&j<m&&!b[i,j]&&prim(a[i,j]))
            {
               
                    nr++;
                    b[i, j] = true;
                    Pi(a, b, i - 1, j);
                    Pi(a, b, i + 1, j);
                    Pi(a, b, i, j + 1);
                    Pi(a, b, i, j - 1);
                
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rnd.Next() % 10;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i,j]+"\t");
                Console.WriteLine();
            }
            int nrmax = 0;
            bool[,] b = new bool[a.GetLength(0), a.GetLength(1)];
            for(int i=0;i<a.GetLength(0);i++)
                 for(int j=0;j<a.GetLength(1);j++)
                    if(!b[i,j])
                {
                    nr = 0;
                    Pi(a, b, i, j);
                        if (nr > nrmax)
                            nrmax = nr;
                }

            Console.WriteLine(nrmax);


        }
    }
}
