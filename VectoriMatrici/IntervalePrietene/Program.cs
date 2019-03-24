using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Model bac 2019
namespace IntervalePrietene
{
    class Program
    {
        static int PrietenMaxim(int[] a, int n)
        {
            int[] frec = new int[101];
            for (int i = 0; i < a.Length; i++)
                frec[a[i]]++;

            int s, lg, smax;
            s = lg = smax = 0;
            for (int i = 0; i < frec.Length; i++)
                if (frec[i] > 0)
                {
                    s = s + frec[i];
                    lg++;
                }
                else
               
                {
                   
                        if(lg>1)
                        if (s > smax)
                             smax = s;
                    lg = s = 0;
                }
                    
                
            
            return smax;
        }
        static void Main(string[] args)
        {



        }
    }
}
