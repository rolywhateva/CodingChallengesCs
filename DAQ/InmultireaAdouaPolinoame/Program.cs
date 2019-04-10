using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmultireaAdouaPolinoame
{

    //De refacut
    class Program
    {
        static void  Multiply(int[] a, int[] b,int[] c, int sta,int dra, int stb, int  drb)
        {
            if(sta==dra||stb==drb)
            {

            }

            int ma = (sta + stb) / 2;
            int mb = (dra + drb) / 2;
            Multiply(a, b, c, sta, ma, stb, mb);
            Multiply(a, b, c, ma + 1, dra, mb, drb);
            Multiply(a, b, c, ma + 1, dra, stb, mb);
            Multiply(a, b, c, sta, ma, mb, drb);
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 7,4,3 };
            int[] b = new int[] { 7, 5, 4, 2 };
            int[] c = new int[a.Length + b.Length];


        }
    }
}
