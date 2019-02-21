using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hackerrank
{
    class SequenceEquation
    {

        #region Sol 1

        /**
         * 
         * <param name="p">The array of integers  </param>
         * <param name="p">The value to be searched. </param>
         * 
         * */
        static int LinearSearch(int [] p, int val)
        {
            for (int i = 0; i < p.Length; i++)
                if (p[i] == val)
                    return i;
            return -1;
        }
        /**
      * 
      * <param name="p">The array of integers  for the  equation.</param>
      * */
        static int[] PermutationEquation(int[] p)
        {
            int[] y = new int[p.Length];
            for (int i = 1; i <= p.Length; i++)
            {
                int poz = LinearSearch(p, i) + 1;
                int yval = LinearSearch(p, poz) + 1;
                y[i - 1] = yval;
            }
            return y;
        }
        #endregion
        #region Sol 2
        static int[] PermutationEquation2(int[] p)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 1; i <= p.Length; i++)
                map.Add(p[i-1], i);
            int[] y = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
                y[i] = map[map[i+1]];
            return y;

        }






        #endregion
        #region Test
        /**
         * <param name="a">The first array </param>
         * <param name="b">The second array</param>
         * */
        static bool EqualArrays(int[] a, int [] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return false;
            return true;
        }
        static void TestSol1()
        {
            int[,][] testArray = new int[3, 2][];
            testArray[0, 0] = new int[] { 5, 2, 1, 3, 4 };
            testArray[0, 1] = new int[] { 4, 2, 5, 1, 3 };
            testArray[1, 0] = new int[] {2,3,1};
            testArray[1, 1] = new int[] {2,3,1};
            testArray[2, 0] = new int[] { 4 ,3 ,5 ,1, 2 };
            testArray[2, 1] = new int[] {1,3,5,4,2 };
            for(int i=0;i<testArray.GetLength(0);i++)
            {
                int[] actualAns = PermutationEquation2(testArray[i, 0]);
                if(!EqualArrays(actualAns,testArray[i,1]))
                {
                    Console.WriteLine("Error at test {0}\n Given answer :{1} \n Actual answer:{2}\n",
                        i + 1,
                        string.Join("  ", actualAns),
                        string.Join("  ", testArray[i, 1])

                        );
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("All tests passed!");
            Console.Beep(); Console.ReadKey();

           
        }
        #endregion


        static void Main()
        {
            #region debug
            bool debug = false;
            if(debug)
            {
                TestSol1();
                return;
            }
            #endregion
            #region filepaths
            string inFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\IN.txt";
            string outFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\Out.txt";
            #endregion
            StreamReader reader = new StreamReader(inFilePath);
            StreamWriter writer = new StreamWriter(outFilePath);
            int n;
            int[] p;
            n = int.Parse(reader.ReadLine());
            p = Array.ConvertAll(reader.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            int[] y = PermutationEquation2(p);
            writer.Write(string.Join("\n", y));



            Console.ReadKey();
            return;
        }
    }
}
