using System;
using System.Collections.Generic;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(sockMerchant(9, a));
        }

        static int sockMerchant(int n, int[] ar)
        {
            HashSet<int> pairCollec = new HashSet<int>();
            int pair = 0;
            for (int i = 0; i < n; i++)
            {
                if (!pairCollec.Contains(ar[i]))
                {
                    pairCollec.Add(ar[i]);
                }
                else
                {
                    pair++;
                    pairCollec.Remove(ar[i]);
                }
            }

            return pair++;
        }
    }
}
