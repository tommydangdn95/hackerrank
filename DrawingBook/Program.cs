using System;

namespace DrawingBook
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(20, 17));
        }


        public static int pageCount(int n, int p)
        {
            return Math.Min(p / 2, n / 2 - p / 2);
        }


        static int pageCountV1(int n, int p)
        {
            int mid;
            if (p == n || p == 1)
                return 0;

            mid = n / 2;

            if (p > mid)
            {
                if (n % 2 == 0)
                {
                    if ((n - p) % 2 == 0)
                        return (n - p) / 2;
                    else
                        return (n - p) / 2 + 1;
                }
                else
                {
                    return (n - p) / 2;
                }
            }
            return p / 2;
        }
    }
}
