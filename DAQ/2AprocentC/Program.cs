using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AprocentC
{
    class Program
    {
        static int DAQ(int A, int B)
        {
            if (A <= 0)
                return 1;
            else
                 if (A % 2 == 0)
                return (DAQ(A / 2, B) * DAQ(A / 2, B)) % B;
            else
                return (2 * DAQ(A - 1, B)) % B;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(DAQ(3,5));
        }
    }
}
