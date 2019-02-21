using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Hackerrank
{
    class EqualizeTheArray
    {
        #region Sol1
        private static int equalizeArray1(int[] arr)
        {
            int[] frecq = new int[101];
            int max = 0, ap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                frecq[arr[i]]++;
                if (frecq[arr[i]] > ap)
                {
                    max = arr[i];
                    ap = frecq[max];
                }
            }
            return arr.Length - ap;
        }
        #endregion
        #region Test 
        struct TestCase
        {
            public int[] arr;
            public int correctAns;
            public TestCase(int[] a, int ans)
            {
                arr = a;
                correctAns = ans;
            }

        };
        private static void Tests(SolFunction sf)
        {
            TestCase[] cases = new TestCase[]
            {
                new TestCase(new int[]{1,2,2,3},2),
                new TestCase(new int[]{3,3,2,1,3},2),
                new TestCase(new int[]{3,3,3,4,4,5},3),
                new TestCase(new int[]{2,3,2,3,1,5,1},5)
            };
            bool perfect = true;
            for (int i = 0; i < cases.Length; i++)
            {
                int givenAns = sf(cases[i].arr);
                if (givenAns != cases[i].correctAns)
                {
                    perfect = false;
                    Console.WriteLine("Error at test {0}!\nCorrect answer : {1}\n  Given answer : {2}\n\n",
                                        i + 1, cases[i].correctAns, givenAns);
                }



            }
            if (perfect)
            {
                Console.WriteLine("All tests passed.");
                Console.Beep();
            }
            Console.ReadKey();
        }
        #endregion
        public delegate int SolFunction(int[] arr);
        static void Main()
        {
            SolFunction sf = equalizeArray1;
            #region Debug
            bool debug = true;
            if (debug)
            {
                Tests(sf);
                return;
            }
            #endregion
            #region filepaths
            string inFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\IN.txt";
            string outFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\Out.txt";
            #endregion

            int n;
            int[] a;
            using (StreamReader reader = new StreamReader(inFilePath))
            {
                n = int.Parse(reader.ReadLine());
                a = Array.ConvertAll(reader.ReadLine().Split(new char[] { ' ' },
                                                            StringSplitOptions.RemoveEmptyEntries), arrayEl => int.Parse(arrayEl));
                reader.Close();
            }

            using (StreamWriter writer = new StreamWriter(outFilePath))
            {
                writer.Write(sf(a));
            }


            Console.ReadKey();
            return;
        }


    }
}
