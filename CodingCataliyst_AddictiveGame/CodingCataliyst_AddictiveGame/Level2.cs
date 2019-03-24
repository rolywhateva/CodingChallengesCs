using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodingCataliyst_AddictiveGame
{
    class Level2
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
                line = reader.ReadLine();
                string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int rows = int.Parse(tokens[0]);
                int column = int.Parse(tokens[1]);


                tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(string.Join(" ", tokens));
                Console.ReadKey();
              
                int NoPoints = tokens.Length / 2;
                int NoColors = tokens.Length / 4;
                int[] colors = new int[NoColors];

                /*
                 * 
                 * 
                 * */
                SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
                for(int i=0;i<tokens.Length;i+=2)
                {
                    int color = int.Parse(tokens[i + 1]);
                    int poz = int.Parse(tokens[i]);
                    if (!dic.ContainsKey(color))
                        dic.Add(color, poz);
                    else
                        dic[color] = Utils.ManhatanDistance(dic[color], poz, rows, column);


                }
                foreach(KeyValuePair<int,int> pair in dic)
                {
                    writer.Write("{0} ", pair.Value);
                    Console.WriteLine("{0} {1}",pair.Key,pair.Value);
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
