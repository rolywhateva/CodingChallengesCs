using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodingCataliyst_AddictiveGame
{
    class Level3
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Date.in");
            StreamWriter writer = new StreamWriter(@"..\..\Date.out");
            string line = reader.ReadLine();
            int n = int.Parse(line);
            for (int test = 1; test <= n; test++)
            {
                writer.WriteLine("Test {0}", test);
                Console.WriteLine("Test {0}", test);
                line = reader.ReadLine();
                string[] dimensions = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int rows =int.Parse(dimensions[0]);
                int column = int.Parse(dimensions[1]);
                Console.WriteLine("{0} {1}",rows,column);
                Console.ReadKey();
                string[] points = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(string.Join(" ", points));
                Console.ReadKey();
                int NoPaths = int.Parse(reader.ReadLine());
                int NoPoints = points.Length / 2;
               
                Dictionary<int, int> pointsDictionary = new Dictionary<int, int>();
                for(int i=0;i<points.Length;i+=2)
                {
                    int poz = int.Parse(points[i]);
                    int color = int.Parse(points[i + 1]);
                    try
                    {
                        pointsDictionary.Add(poz, color);
                    }
                    catch
                    {
                        Console.WriteLine(poz);
                    }

                }
                for(int path =1;path<=NoPaths;path++)
                {
                    string[] pathData = reader.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                    int pathColor = int.Parse(pathData[0]);
                    int start = int.Parse(pathData[1]);
                    string[] steps = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int pathLength = Utils.ValidPath(rows, column, start, pathColor, pointsDictionary,steps,out bool success);
                    int ans = 1;
                    if (!success)
                        ans *= -1;
                    Console.WriteLine(string.Join(",", pathData));
                    Console.WriteLine(string.Join(",", steps));
                    writer.Write("{0} {1}", ans, pathLength);
                   Console.WriteLine("{0} {1}", ans, pathLength);
                    Console.ReadKey();

                }


               


                Console.ReadKey();

                writer.WriteLine();









            }
            writer.Close();

            Console.WriteLine(Utils.ManhatanDistance(1, 12, 6, 5));
            Console.WriteLine(Utils.ManhatanDistance(5, 26, 6, 5));
            Console.ReadKey();


            return;


        }

    
    }
}
