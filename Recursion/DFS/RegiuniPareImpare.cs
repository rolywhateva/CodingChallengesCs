using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DFS
{
    class RegiuniPareImpare
    {
        static int lg;
        static int n, m;
        static bool bordpar, bordimpar;
        static bool[,] b;
        static void PA(int[,] a, bool[,] b, int i, int j,int start)
        {
            if(i>=0&&j>=0&&i<n&&j<m&&!b[i,j])
            {
                if(a[i,j]%2!=start%2)
                {
                    if (a[i, j] % 2 == 0)
                        bordpar = true;
                    else
                        bordimpar = true;
                }
                else
                {
                    lg++;
                    b[i, j] = true;
                    PA(a, b, i - 1, j, start);
                    PA(a, b, i, j + 1, start);
                    PA(a, b, i + 1, j, start);
                    PA(a, b, i, j - 1, start);
                }
            }
        }
        static void Main()
        {
            int[,] a;
            string[] lines;
            string[] tokens;
            using (StreamReader reader = new StreamReader("../../Intrare.txt"))
            {
                lines = reader.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lines.Length; i++)
                    Console.WriteLine(lines[i]);
                Console.WriteLine("====");
                n = lines.Length;
                m = lines[0].Split(' ').Length-1;
                a = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    tokens = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < tokens.Length; j++)
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
            bool[,] b = new bool[n, m];
            int nr = 0;
           for(int i=0;i<n;i++)
                for(int j=0;j<m;j++)
                     if(!b[i,j])
                    {
                        lg = 0;
                        bordpar = bordimpar = false;
                        PA(a, b, i, j, a[i, j]);
                        if(a[i,j]%2==0&&bordimpar||a[i,j]%2!=0&&bordpar)
                             nr++;
                    }

            Console.WriteLine(nr);
            return;
        }
    }
}
