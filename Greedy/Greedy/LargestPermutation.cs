using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class LargestPermutation
    {
        static void Swap(ref int a,ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static int[] Permutation(int[] a, int k)
        {
            int[] index = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                index[i] = i;
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = a[i];
            for(int i=0;i<b.Length;i++)
                for(int j=i+1;j<b.Length;j++)
                     if(b[i]<b[j])
                    {
                        Swap(ref b[i], ref b[j]);
                        Swap(ref index[i], ref index[j]);
                    }
            int sw = 0;
            for(int i=0;i<a.Length&&sw<k;i++)
                 if(i!=index[i])
                {
                    Swap(ref a[i], ref a[index[i]]);
                    Swap(ref index[i],ref  index[index[i]]);
                        sw++;
                }
            return a;

        }
        static int[] PermutationFaster(int[] a, int k)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int[] b = new int[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                hash.Add(a[i], i);
                b[i] = a.Length - i;
                
            }
            int sw = 0;
            for(int i=0;i<a.Length&&sw<k;i++)
                  if(i!=hash[b[i]])
                {
                    Swap(ref a[i], ref a[hash[b[i]]]);
                   
                    sw++;
                }
            return a;
        }
        static int[] PermutationFaster2(int [] a, int k)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
          //  int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                hash.Add(a[i], i);
               // b[i] = a.Length - i;

            }
            int sw = 0;
            int n = a.Length;
            for (int i = 0; i < a.Length && sw < k;n--, i++)
                if (i != hash[n])
                {
                   
                    Swap(ref a[i], ref a[hash[n]]);
              
                 

                   
                   
 
                    sw++;
                }
            return a;
        }
        static int[] PermutationFaster3(int[] a, int k)
        {
            int sw = 0;
            int n = a.Length;
            int[] index = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                index[a[i] - 1] = i;

            for (int i = 0; i < a.Length && sw < k; i++)
                if (a[i] != a.Length - i)
                {
                    int toSwitch = index[a.Length - i - 1];
                    Swap(ref index[a[i]-1], ref index[a.Length - i - 1]);
                    Swap(ref a[i], ref a[toSwitch]);



                    sw++;
             

                }
            return a;
        }
        static void Main()
        {
            int[] a = new int[] { 1,2,3,7,6,4,5};
            int[] rez = PermutationFaster3(a, 5);
            Console.WriteLine("{0}", string.Join(",", rez));



            return;
        }
    }
}
