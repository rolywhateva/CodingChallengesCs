using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodingCataliyst_AddictiveGame
{
    class Level1
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Date.in");
            StreamWriter writer = new StreamWriter(@"..\..\Date.out");
            string line = reader.ReadLine();
            int n = int.Parse(line);
            for (int test = 1; test <= n; test++)
            {
                writer.WriteLine("Test {0}", test);
                line = reader.ReadLine();
                string[] tokens = line.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                int rows = int.Parse(tokens[0]);
                int column = int.Parse(tokens[1]);
                int positions = int.Parse(tokens[2]);
                int[] positionsArray = new int[positions];
                for (int i = 3; i < tokens.Length; i++)
                    try
                    {
                        positionsArray[i - 3] = int.Parse(tokens[i]);
                    }catch(Exception e)
                    {
                        Console.WriteLine(test);
                        throw e;
                    }
             
              //  Array.Sort(positionsArray);

                Console.WriteLine(string.Join(",", positionsArray));
                Console.ReadKey();
                for(int i=0;i<positionsArray.Length;i++)
                {
                    int x, y;
                    Utils.Position(positionsArray[i], rows, column, out x, out y);
                    writer.WriteLine(" {0} {1}", x, y);

                }

                writer.WriteLine();
            }
            reader.Close();
            writer.Close();
            Console.ReadKey();
  

        }
    }
}
