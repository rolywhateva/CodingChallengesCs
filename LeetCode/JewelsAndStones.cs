using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class JewelsAndStones
    {
        static int  sol(string J, string S)
        {
            HashSet<char> jewels = new HashSet<char>();
            for (int i = 0; i < J.Length; i++)
                jewels.Add(J[i]);
            int nr = 0;
            for (int i = 0; i < S.Length; i++)
                if (jewels.Contains(S[i]))
                    nr++;
            return nr;
        }
        static void Main()
        {
            

          
            return;
        }
    }
}
