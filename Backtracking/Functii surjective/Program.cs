﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii_surjective
{
    class Program
    {
        static void bk(int k, int nA, int nB, int[] st, int[] frec)
        {
            Console.WriteLine("*");
            if(k>=nA)
            {
                for(int i=0;i<k;i++)
                    Console.WriteLine("f({0})={1}",i+1,st[i]);
                Console.WriteLine("=============================");
            }else
            {
                for (int i = 0; i < nB; i++)
                {
                    if (frec[i] < 2)
                    {
                        st[k] = i + 1;
                        frec[i]++;
                        bk(k + 1, nA, nB, st, frec);
                        frec[i]--;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int nA, nB;
            Console.Write("nA=");
            nA = int.Parse(Console.ReadLine());
            Console.Write("nB=");
            nB = int.Parse(Console.ReadLine());
            int[] st, frec;
            st = new int[nA];
            frec = new int[nB];
            bk(0, nA, nB, st, frec);


        }
    }
}
