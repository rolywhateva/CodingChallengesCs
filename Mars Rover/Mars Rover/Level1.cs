using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    class Level1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:f2}",Utils.TurnRadius(1f, 30f));
            Console.WriteLine("{0:f2}",Utils.TurnRadius(1f, 13.76f));
            Console.WriteLine("{0:f2}", Utils.TurnRadius(1f, 13.76f));
            Console.WriteLine("{0:f2}", Utils.TurnRadius(1f, 2.34f));
            Console.WriteLine("{0:f2}", Utils.TurnRadius(1f, 90f));
            Console.WriteLine("{0:f2}", Utils.TurnRadius(2.45f,90.00f));


        }
    }
}
