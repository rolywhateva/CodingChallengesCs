using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DFS
{
    class NrPlatouriCuElEgale
    {
        static int n, m, lg;
        static void PA(int[,] a, bool[,] b, int i, int j, int val)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j] && a[i, j] == val)
            {
                b[i, j] = true;
                lg++;
                PA(a, b, i - 1, j, val);
                PA(a, b, i, j + 1, val);
                PA(a, b, i + 1, j, val);
                PA(a, b, i, j - 1, val);
            }
        }
        static void Main()
        {
            int[,] a;
            string[] lines;
            string[] tokens;
            using (StreamReader reader = new StreamReader("../../Intrare.txt"))
            {
                lines = reader.ReadToEnd().Split(new char[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
                for(int i=0;i<lines.Length;i++)
                    Console.WriteLine(lines[i]);
                Console.WriteLine("====");
                n = lines.Length;
                m = lines[0].Split(' ').Length;
                a = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    tokens = lines[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j <tokens.Length ; j++)
                    {
                        try
                        {
                            a[i, j] = int.Parse(tokens[j]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(tokens[j]);
                        }
                    }
                }

            }
       
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            
            int nr = 0;
            int lgmax = 0, nrmax = 0;
            bool[,] b = new bool[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!b[i, j])
                    {
                        lg = 0;
                        PA(a, b, i, j, a[i,j]);
                        if (lg > 1)
                        {
                            nr++;
                            if(lg>lgmax)
                            {
                                lgmax = lg;
                                nrmax = 0;
                            }
                                 if(lg==lgmax)
                            {
                                nrmax++;
                            }
                        }
                    }
            Console.WriteLine("Numarul de platouri:"+nr);

            Console.WriteLine("Marimea maxima : "+  lgmax);
            Console.WriteLine("Numarul de platouri cu marima maxima : "+nrmax);
           
            


            return;
        }
    }
}
