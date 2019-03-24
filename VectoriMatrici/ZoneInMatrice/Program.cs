using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoneInMatrice
{
    class Program
    {
        #region Diagonala principala
        static void DPrincipala(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write(a[i,i] + "\t");
            Console.WriteLine();
                   

        }
        #endregion
        #region Diagonala secundara
        static void DSecundara(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write(a[i,a.GetLength(0) - 1 - i] + "\t");
            Console.WriteLine();
        }
        #endregion
        #region Deasupra dig.principale
        static void NPrincpala(int[,] a)
        {
            //i<j
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = i + 1; j < a.GetLength(0); j++)
                    Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
        #endregion
        #region  sub diagonala principala
        static void  SPrincipala(int[,] a)
        {
            //i>j
            for(int i=a.GetLength(0)-1;i>=0;i--)
            {
                for (int j = 0; j <i; j++)
                    Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        #endregion
        #region deasupra diagonalei secundare
        static void NordSecundara(int[,] a)
        {
            //i+j<n-1
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(0) - 1-i; j++)
                    Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        #endregion
        #region sub diagonala secundara
        static void SudSecundara(int[,] a)
        {
            //i+j>n-1
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = a.GetLength(0) - i; j < a.GetLength(0); j++)
                    Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        #endregion
        #region Simetric diagonala principala
        static int[,] simetricdprip(int[,] a)
        {
            //a[i,j] <-->a[j,i]
            int n = a.GetLength(0);
            int[,] nou = new int[n, n];
            /*
            for (int i = 0; i < n; i++)
                nou[i, i] = a[i, i];
                */
            for (int i = 0; i < n; i++)
                for (int j = i ; j < n; j++)
                {
                    nou[i, j] = a[j, i];
                    nou[j, i] = a[i, j];
                }
            return nou;

        }
        #endregion
        #region Simetric diagonala secundara
        static int[,] simetricdsec(int[,] a)
        {
            int n = a.GetLength(0);
            int[,] nou = new int[n, n];
            for(int i=0;i<n;i++)
            {
                for(int j =0;j<n-i;j++)
                {
                    nou[i, j] = a[n - 1 - j, n - 1 - i];
                    nou[n - 1 - j, n - 1 - i] =a[i, j];
                }
            }
            return nou;
        }
        #endregion
        #region N,S,V,E
        static void Nord(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i < j && i + j < n - 1)
                        Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
        static void Sud(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i >j && i + j >n - 1)
                        Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
        static void Vest(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i>j&&i+j<n-1)
                        Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
        static void Est(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i<j&&i+j>n-1)
                        Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
        #endregion
        #region transpusa
        static int[,] transpusa(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] nou = new int[m, n];
            for(int i=0;i<m;i++)
                 for(int j=0;j<n;j++)
                {
                    nou[i, j] = a[j, i];
                }
            return nou;
           
        }
        #endregion
        #region serpuit
        static void Serpuit(int[,] a)
        {
            int nr =1;
            int n = a.GetLength(0);
            /*
            for (int j = 1; j <=n; j++)
            {
                for (int i = 0; i < j; i++)
                    Console.Write(a[i, j - 1 - i] + "\t");
            }
            for(int j=n+1;j<2*n-1; j++)
            {
                for (int i = 1; i < j; i++)
                    Console.Write(a[i, j - 1 - i] + "\t");

            }*/
           
            for(int i=0;i<n;i++)

            { 
               
                   for (int j = i, k = 0; j >= 0; j--, k++)
                        Console.Write(a[j,k] + "\t");
                

            }
            for(int i=1;i<n;i++)
            {
                for (int j = n - 1, k = i; j >= i; j--, k++)
                    Console.Write(a[j, k] + "\t");
            }
          
      

          







        }
        #endregion
        #region fill serpuit
        static int[,]  fill(int n,int x, int y)
        {
            int[,] a = new int[n, n];
            for(int i=0;i<n;i++)
            {
                if((i+1)%2==0)
                    for (int j = i, k = 0; j >= 0; j--, k++)
                      a[j, k] =a[n-1-k,n-1-j]= x;
                else 
                for (int j = 0, k = i; j <= i; j++, k--)
                    a[j, k] =a[n-1-k,n-1-j]= y;
            }


            return a;
        }
        #endregion
        #region utils
        static int[,] matrice(int n,int m=0)
        {
            if (m == 0) 
                m = n;
            int[,] a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rnd.Next(10);
            return a;
        }
        static void Write(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
#endregion
     
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //a = matrice(6);

            Write(a);
            Console.WriteLine("Diagonala principala:");
            DPrincipala(a);
            Console.WriteLine("Diagonala secundara:");
            DSecundara(a);
            Console.WriteLine("Deaspura diagonalei principale:");
            NPrincpala(a);
            Console.WriteLine("Sub  diagonala principala:");
            SPrincipala(a);
            Console.WriteLine("Deasupra diagonalei secundare");
            NordSecundara(a);
            Console.WriteLine("Sub diagonala secundara:");
            SudSecundara(a);
            Console.WriteLine("Simetric diagonala princiapala:");
            Write(simetricdprip(a));
            Console.WriteLine("Simetric diagonala secundara:");
            Write(simetricdsec(a));
            Console.Write("N:");
            Nord(a);
            Console.Write("S:");
            Sud(a);
            Console.Write("E:");
            Est(a);
            Console.Write("V:");
            Vest(a);
           // int[,] b = matrice(4, 3);
           // Write(b);
            Write(transpusa(a));
            Serpuit(a);
            Console.WriteLine();
            Write(fill(3, 1, 0));




            Console.ReadKey();
        }
    }
}
