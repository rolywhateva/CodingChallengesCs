using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class RemoveablePrimes
    {
        static bool   Prim(ulong nr)
        {
            if (nr < 2)
                return false;
            if (nr == 2)
                return true;
            if (nr % 2 == 0)
                return false;
            for (ulong d = 3; d * d <= nr; d += 2)
                if (nr % d == 0)
                    return false;
            return true;
        }
      /*
       static  void  Posibilitati(string  numar, ref   int nr)
        {
           if(Prim(ulong.Parse(numar)))
            {
                if (numar.Length == 1)
                  Posibilitati(numar,)
                else
                    for (int i = 0; i < numar.Length; i++)
                    {
                        string aux = numar.Remove(i, 1);
                        return 0+Posibilitati(aux);
                    }
            }
            return 0;

                   
        }
        */
        static void Main()
        {
            string[] sol = new string[] { "4125673" , "41256793" , "337424981" , "537430451" , "200899998" , "537499093" , "2147483059" , "410256793" , "567629137" , "46216567629137" };
          //  Console.WriteLine(Posibilitati("4567"));

            Console.ReadKey();

            return;
        }
    }
}
