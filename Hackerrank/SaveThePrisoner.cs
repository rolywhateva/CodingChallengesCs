using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
//https://www.hackerrank.com/challenges/save-the-prisoner/problem
namespace Hackerrank
{



    class PbSaveThePrisoner
    {
        /**
         * <param name="n">Number of prisoners(int) </param>
         * <param name="m">Number of  sweets(int)</param>
         * <param name="s">The number of the seat  the counting starts with(int)</param>
         */
        static int SaveThePrisoner(int n, int m, int s)
        {
            int toWarn = (s + m - 1) % n;
            if (toWarn == 0)
                return n;
            else
                return toWarn;

        }
        #region test functions
        static int? TestSaveThePrisoner(int n, int m, int s, int ans)
        {
            int actualAns = SaveThePrisoner(n, m, s);
            if (actualAns == ans)
                return null;
            else
                return actualAns;
        }
        static void Tests()
        {
            int[,] testData = new int[,]
            {
                {5,2,1,2},
                {5,2,2,3 },
                {7,19,2,6 },
                {3,7,3,3 },
                {236,70,50, 119 }
            };
            for(int testCounter=0;testCounter<testData.GetLength(0);testCounter++)
            {
                int? verdict = TestSaveThePrisoner(testData[testCounter, 0], 
                                                   testData[testCounter, 1], 
                                                   testData[testCounter, 2], 
                                                   testData[testCounter, 3]);
                if(verdict!=null)
                    Console.WriteLine("Error at test {0} :\nGiven Answer : {1}", 
                                       testCounter + 1, verdict);
                

            }
            Console.WriteLine("All tests passed!");
            Console.Beep();Console.ReadKey();


        }
        #endregion


        static void Main(string[] args)
        {
            #region Debug
            bool debug = false;
            if (debug)
            {
                Tests();
                return;
            }
            #endregion
            #region filepaths
            string inFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\IN.txt";
            string outFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\Out.txt";
            #endregion
                StreamReader reader = new StreamReader(inFilePath);
                StreamWriter writer = new StreamWriter(outFilePath);
                int t, n, m, s;
                string[] tokens;
                t = int.Parse(reader.ReadLine());
                for(int qCounter=0;qCounter<t;qCounter++)
                {
                    tokens = reader.ReadLine().Split(new char[] { ' ' }, 
                             StringSplitOptions.RemoveEmptyEntries);
                    n = int.Parse(tokens[0]);
                    m = int.Parse(tokens[1]);
                    s = int.Parse(tokens[2]);
                    writer.WriteLine(SaveThePrisoner(n, m, s));

                }
                reader.Close();
                Console.ReadKey();
        }
    }
}
