using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PlatouriInMatrice
{
    class Program
    {
        static void Write(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            string[] line;
            string path = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff2\C#\CodingChallenges\VectoriMatrici\PlatouriInMatrice\matrice.txt";
            int[,] a;
            int n, m;
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadLine().Split(new char[] { ' ' });
                n = int.Parse(line[0]);
                m = int.Parse(line[1]);
                a = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine().Split(new char[] { ' ' });
                    for (int j = 0; j < m; j++)
                        a[i, j] = int.Parse(line[j]);
                }

            }
            int ariemax = 0, colprev = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] % 2 == 0)
                    {
                        int z = 0;
                        int lin = 0, col = 0;
                        while (j+z<m&&a[i, j + z] % 2 == 0)
                        {
                            int xi = i;
                            int xj = j;
                            while (xi < n && a[xi, xj] % 2 == 0)
                                xi++;
                            lin = xi - i + 1;
                            if (lin >= colprev)
                                col++;
                            
                            colprev = lin;

                            z++;

                        }
                        if (col > 1 && lin > 1)
                        {
                            int arie = lin * col;
                            if (ariemax > arie)
                                ariemax = arie;
                        }

                    }
            Write(a);
            Console.WriteLine(ariemax);
            Console.ReadKey();









        }
    }
}

