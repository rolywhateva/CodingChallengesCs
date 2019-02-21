using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//https://www.hackerrank.com/challenges/non-divisible-subset/problem
namespace Hackerrank
{
    class NonDivisibleSubset
    {
        static int nonDivisibleSubset(int k, int[] S)
        {
            /*
            int nr = 0, s1 = 0, s2 = 0;
            bool onediv = false;
            int? lastNumber = null;
            for (int i = 0; i < S.Length; i++)
                if (S[i] % k == 0 && !onediv)
                {
                    onediv = true;
                    // lastNumber = S[i];
                    nr++;
                   
                }
                else
                    if (lastNumber == null)
                {
                    lastNumber = S[i];
                    s1 += S[i] % k;
                    nr++;
                }
                else
                {
                    if (S[i] % k != 0 && lastNumber % k!=S[i]%k&&(s1%k-2*(S[i]%k))%k!=0)
                    {
                        nr++;
                        lastNumber = S[i];
                        s1 += S[i] % k;
                    }
                }
                */

            List<int> list = new List<int>();
            bool onediv = false;
            for(int i=0;i<S.Length;i++)
                 if(S[i]%k==0&&!onediv)
                {
                    list.Add(S[i]);
                    onediv = true;
                }else
                {
                    bool ok = true;
                    for (int j = 0; j < list.Count && ok; j++)
                        if ((list[j] + S[i]) % k == 0)
                        {
                            ok = false;
                          
                        }
                    if (ok)
                        list.Add(S[i]);
                }
            return list.Count;
            
        }
        static void Tests()
        {
            int[][] testArray = new int[2][];
            int[] kArray = new int[] { 4, 3 };
            int[] correctAns = new int[] {3,3 };
            testArray[0] = new int[] { 19, 10, 12, 24, 25, 22 };
            testArray[1] = new int[] { 1, 7, 2, 4 };
            int tests = 0;
            for(int i=0;i<testArray.GetLength(0);i++)
            {
                int actualAns = nonDivisibleSubset(kArray[i], testArray[i]);

                if (actualAns != correctAns[i])
                {
                    Console.WriteLine("Error test {0}!\n---Actual ans :{1}!\n---Correct ans :{2}"
                                       , i + 1, actualAns, correctAns[i]);

                }
                else tests++;
            }
            if (tests == testArray.GetLength(0))
            {
                Console.Beep();
              
                Console.WriteLine("All tests passed!");
            }
            Console.ReadKey();



        }
        static void Main()
        {
            #region Debug
            bool debug = true;
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
            int n, k;
            string[] nk;
            nk = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(nk[0]);
            k = int.Parse(nk[1]);
            int[] a;
            a = Array.ConvertAll(reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 ,s => int.Parse(s));


            return;
        }

    }
}
