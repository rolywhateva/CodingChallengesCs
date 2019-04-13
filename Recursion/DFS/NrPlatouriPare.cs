using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class NrPlatouriPare
    {
        static int lg;
        static int n, m;
        static bool[,] b;
        static void PA(int[,] a, bool[,] b, int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j]&&a[i,j]%2==0)
            {


                b[i, j] = true;
                    lg++;
                    PA(a, b, i, j - 1);
                    PA(a, b, i, j + 1);
                    PA(a, b, i + 1, j);
                    PA(a, b, i - 1, j);
                
            }
        }
        static void Main()
        {
            int[,] a = new int[3, 3];
            n = a.GetLength(0);
            m = a.GetLength(1);
            Random rnd = new Random();
            for (int i = 0; i <n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rnd.Next() % 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
           b = new bool[n, m];
            int nr = 0;
            for(int i=0;i<n;i++)
                 for(int j=0;j<m;j++)
                     if(a[i,j]%2==0&&!b[i,j])
                    {
                        lg = 0;
                        PA(a, b, i, j);
                        if (lg > 1)
                            nr++;


                    }
            Console.WriteLine("Numarul de platouri de numere pare :" + nr);

                   
        }
    }
}
