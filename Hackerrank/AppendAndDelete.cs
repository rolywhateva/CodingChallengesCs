using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/// <summary>
/// Redo!
/// </summary>
namespace Hackerrank
{
    class AppendAndDelete
    {
        #region Sol1
        static string appendAndDelete(string s, string t, int k)
        {
            if (s.CompareTo(t) == 0)
                
                return "Yes";

            int i = 0, length = 0;

            if (s.Length < t.Length)
                length = s.Length;
            else
                length = t.Length;
            while (i < length && s[i] == t[i])
                i++;

            if (s.CompareTo(t) == 0)
                if (s.Length == k)
                    return "Yes";
                else
                    return "No";
                
                if (s.Length + t.Length - 2 * i == k)
                    return "Yes";
                else
                    return "No";


        }
        #endregion
        static void Main()
        {

            #region debug
            bool debug = false;
            if (debug)
            {
              //  TestSol1();
                return;
            }
            #endregion
            #region filepaths
            string inFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\IN.txt";
            string outFilePath = @"C:\Users\rolan\OneDrive\Asztali gép\Stuff\C#\CodingChallengesCs\Hackerrank\Out.txt";
            #endregion
            StreamReader reader = new StreamReader(inFilePath);
            StreamWriter writer = new StreamWriter(outFilePath);
            string s, t;
            int k;
            s = reader.ReadLine();
            t = reader.ReadLine();
            k = int.Parse(reader.ReadLine());




            return;
        }
    }
}
