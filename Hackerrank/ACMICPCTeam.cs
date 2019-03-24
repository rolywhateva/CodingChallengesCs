using System;

//https://www.hackerrank.com/challenges/acm-icpc-team/problem
namespace Hackerrank
{
    class ACMICPCTeam
    {
        static int[] acmTeam(string[] topic)
        {
            int max = 0;
            int count = 0;
           for(int i=0;i<topic.Length;i++)
                for(int j=i+1;j<topic.Length;j++)
                {
                    int nr = 0;
                    for (int z = 0; z < topic[j].Length; z++)
                        if (topic[i][z] == 1 || topic[j][z] == 1)
                            nr++;
                    if (nr > max)
                    {
                        max = nr;
                        count = 1;
                    }
                    else
                         if (nr == max)
                        count++;
                }
            return new int[] { max, count};

        }
        static void Main()
        {



            Console.ReadKey();
            return;
        }
    }
}
