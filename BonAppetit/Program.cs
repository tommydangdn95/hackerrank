using System;
using System.Collections.Generic;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bill = new List<int> { 3, 10, 2, 9 };
            bonAppetit(bill, 1, 12);
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            var totalSharePaid = CalculateBill(bill, bill.Count, k) / 2;
            if(totalSharePaid < b)
            {
                Console.WriteLine(b-totalSharePaid);
            }
            else if(b == totalSharePaid)
            {
                Console.WriteLine("Bon Appetit");
            }
        }


        static int CalculateBill(List<int> bill, int length, int k)
        {
            if (length <= 0)
                return 0;
            if (length - 1 == k)
            {
                return bill[length - 2] + CalculateBill(bill, length - 2, k);
            }
            return bill[length - 1] + CalculateBill(bill, length - 1, k);
        }
    }
}
