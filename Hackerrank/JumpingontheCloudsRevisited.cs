using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Hackerrank
{
    class JumpingontheCloudsRevisited
    {
        private static int GCD(int a, int b)
        {
            int r = a % b;
            while(r!=0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }
        private static  int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        private static int jumpingOnClouds(int[] c, int k)
        {
            int thunderHeads = 0;
            for (int i = 0; i < c.Length; i++)
                if (c[i] == 1&&i%k==0)
                    thunderHeads++;
            
            int steps = c.Length / k;
            int thunderHeadSteps = 2* thunderHeads;
            return 100 - steps -  thunderHeadSteps;

        }
        struct testcase
        {
            public int[] c;
            public int k;
            public int expectedAns;
            public testcase(int[] a, int b ,int ans)
            {
                c = new int[a.Length];
                a.CopyTo(c,0);
                k = b;
                expectedAns = ans;
            }
        }
        static void Tests()
        {
            testcase[] cases = new testcase[]
            {
                new testcase(new int[]{0, 0, 1, 0 ,0 ,1 ,1, 0},2,92)
            };
            bool fail = false;
            for (int i = 0; i < cases.Length; i++)
            {
                int givenAns = jumpingOnClouds(cases[i].c, cases[i].k);
                if ( givenAns!= cases[i].expectedAns)
                {
                    Console.WriteLine("Error test {0}\nGiven ans:{1}\nCorrect ans:{2}",
                                      i+1,givenAns,cases[i].expectedAns);

                    fail = true;

                }


            }
            if(!fail)
            {
                Console.WriteLine("All tests passed!");
                Console.Beep();
               
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
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c, k);

            return;
        }

        
    }
}
