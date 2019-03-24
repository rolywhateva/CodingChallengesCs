using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StergereZero
{
    class Program
    {
        static void Stergere(ref int[] a, int val)
        {
            int nr = 0;
           for(int i=0;i<a.Length-nr;i++)
            {
                if(a[i]==val)
                {
                    nr++;
                    int aux = a[i];
                    a[i] = a[a.Length  - nr];
                    a[a.Length - nr] = aux;
                    while (a[a.Length - nr-1] == val)
                        nr++;

                }
            }
            Array.Resize(ref a, a.Length - nr);


        }
        static void Stergere2(ref int[] a, int val)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==val)
                {
                    for (int j = i; j < a.Length-1; j++)
                        a[j] = a[j + 1];
                    Array.Resize(ref a, a.Length - 1);
                    i--;
                }
            }
        }
        static void Inserare(ref int[] a, int val, int poz)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(i==poz)
                {
                    Array.Resize(ref a, a.Length + 1);
                    for (int j = a.Length-1; j > poz; j--)
                        a[j] = a[j - 1];
                    a[poz] = val;
                }
            }
        }
        static bool Prim(int n)
        {
            if (n <2)
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void StergerePrim(ref int[] a)
        {
             for(int i=0;i<a.Length;i++)
                 if(Prim(a[i]))
                {
                    for (int j = i; j < a.Length - 1; j++)
                        a[j] = a[j + 1];
                    Array.Resize(ref a, a.Length - 1);
                    i--;

                }
           
        }
        static void StergereMultipla(ref int[] a, int poz, int nr)
        {
            for(int i=0;i<a.Length;i++)
                 if(i==poz)
                {
                    for(int j = 1;j<=nr;j++)
                    {
                        for (int z = i; z < a.Length - 1; z++)
                            a[z] = a[z + 1];
                        Array.Resize(ref a, a.Length - 1);
                      
                   }
                   
                }
        }
        static void  StergereSecventeEgale(ref int[] a)
        {
            int lg;
            bool ok;
            do
            {
                ok = true;
                lg = 0;
                for (int i = 0; i < a.Length - 1; i++)
                    if (a[i] == a[i + 1])
                    {
                        lg++;
                    }
                    else
                        if (lg > 0)
                    {
                        lg++;
                        for (int j =0;j<lg;j++)
                        {
                            for (int z =i-lg+1; z < a.Length - 1; z++)
                                a[z] = a[z + 1];
                            Array.Resize(ref a, a.Length - 1);
                        }
                        ok = false;
                    }
            } while (!ok);
        }
        static void InserareMultipla(ref int[] a, int poz,  int[] b)
        {
            for(int i=0;i<a.Length;i++)
              if(i==poz)
                {
             
                    for(int j=0;j<b.Length;j++)
                    {
                        Array.Resize(ref a, a.Length + 1);
                        for (int z = a.Length-1; z > i + j; z--)
                            a[z] = a[z - 1];
                        a[i + j+1] = b[j];


                    }
                }
        }
        static void InserareMultipla2(ref int[] a, int poz, int[] b)
        {
          
            for(int i=0;i<a.Length;i++)
                if(i>=poz&&i<=poz+b.Length-1)
                {
                    Array.Resize(ref a, a.Length + 1);
                    for (int j = a.Length - 1; j >i; j--)
                        a[j] = a[j - 1];
                    a[i+1] = b[i - poz];
                }
        }
        static void InserareDublu(ref int[] a)
        {
            for(int i=0;i<a.Length;i++)
                 if(a[i]%2==0)
                {
                    Array.Resize(ref a, a.Length + 1);
                    for (int j = a.Length - 1; j >= i+ 1; j--)
                        a[j] = a[j - 1];
                    a[i + 1] = a[i] * 2;
                    i++;
                }
        }

        static void Main(string[] args)
        {
            int[] a = new int[] {1,2,3};
            
            Console.WriteLine("({0})", string.Join(",", a));
            // Stergere2(ref a, 0);
            //  Inserare(ref a, 5, 2);
            //StergerePrim(ref a);
            //   InserareDublu(ref a);
            // StergereMultipla(ref a, 0, 3);
            // StergereSecventeEgale(ref a);
            InserareMultipla2(ref a, 2, new int[] { 5, 6, 7 });
            Console.WriteLine();
            Console.WriteLine("({0})", string.Join(",", a));
            Console.ReadKey();

        }
    }
}
