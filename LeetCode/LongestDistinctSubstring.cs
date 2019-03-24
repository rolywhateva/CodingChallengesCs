using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//De refacut! 
namespace LeetCode
{
    class LongestDistinctSubstring
    {
        static int sol1(string s)
        {
            
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int maxLength = 0, start = 0;
            for (int i = 0; i < s.Length; i++)
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                } else
                {
                    if (i - start > maxLength)
                        maxLength = i - start;

                    start = dic[s[i]] + 1;
                    dic[s[i]] = i;


                }
            if (s.Length  -start > maxLength)
                maxLength = s.Length  - start;
            return maxLength;

        }
        public delegate int Sol(string s);
        public static void Test(Sol  function)
        {
            Dictionary<string, int> testCases = new Dictionary<string, int>();
            testCases.Add("abcbcd", 3);
            testCases.Add("abcebcd", 4);
            testCases.Add("abcbdefgge", 6);
            testCases.Add("abababababcdefg", 7);
           foreach(string s in testCases.Keys)
            {
                int ans = function(s);
                if (ans == testCases[s])
                    Console.WriteLine("{0}=>{1}", s,ans);
                else
                    Console.WriteLine("{0}=/=>{1}", s, testCases[s]);
               

            }
        }
        static void Main(string[] args)
        {
            bool debug = true;
            if(debug)
            {
                Test(new Sol(sol1));
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
            return;
        }
    }
}
