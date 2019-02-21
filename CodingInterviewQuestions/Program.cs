using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewQuestions
{
    /*
     * 1.How do you find the missing number 
     * in a given integer array of 1 to 100? 
     * */

    class Program
    {
        // if all elements are different
        int Sol11(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
                s = s + arr[i];
            int sum100 = arr.Length * (arr.Length + 1) / 2;
            return sum100 - s;
        }
        // if there are repeated values
        int Sol12(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] - arr[i - 1] > 1)
                    return arr[i - 1] + 1;
            return arr[arr.Length];


        }

        /**
         * 
         * 2.How do you find the duplicate number on a given integer array
         * 
        if there are more duplicate numbers(Dictionary)
      **/
        private IEnumerable<int> Sol21(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
                if (dic.ContainsKey(arr[i]))
                    yield return arr[i];
                else
                    dic.Add(arr[i],1);
           
        }
        //if there are more duplicate numbers(sorting)
        private IEnumerable<int> Sol22(int[] arr)
        {
            Array.Sort(arr);
            int added = 0;
            for (int i = 1; i < arr.Length - 1; i++)
                if (arr[i - 1] == arr[i] && arr[i] != arr[i + 1])
                {
                    yield return arr[i];
                    added++;
                }
            if (added == 0)
                yield return arr[0];
            

        }
        
        static void Main(string[] args)
        {








            return;
        }
    }
}
