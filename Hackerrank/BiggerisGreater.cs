using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// unfinisihed!
/// </summary>
namespace Hackerrank
{
    class BiggerisGreater
    {
        static string biggerIsGreater(string w)
        {
            int[] frec = new  int[65];
            int first = w[0];
            int min = 65;
            for (int i = 0; i < w.Length; i++)
            {
                frec[w[i] - first + 32]++;
                if(w[i]-first<min && w[i]-first>0)
                    min = w[i] - first;
                
            }
            string s = "";
            s = s + ((char)(first + min - 32)).ToString();
            for (int i = 0; i < frec.Length; i++)
                if (frec[i] != 0&&first+i-32!=min)
                    s = s + ((char)(first + i - 32)).ToString();
            return s;

            


            


        }

        static void Main()
        {


            Console.ReadKey();
            return;
        }
    }
}
