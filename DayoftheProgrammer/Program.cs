using System;

namespace DayoftheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2017;
            Console.WriteLine(CalculateDayProgrammer(year).ToString("dd.MM.yyyy"));
        }

        private static DateTime CalculateDayProgrammer(int year)
        {
            DateTime programmerDay;
            if(year == 1918)
            {
                programmerDay = new DateTime(1918, 09, 26);
            }
            else if (year < 1918)
            {
                if(year % 4 == 0)
                {
                    programmerDay = new DateTime(year, 9, 13);
                }
                else
                {
                    programmerDay = new DateTime(year, 9, 12);
                }
            }
            else
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    programmerDay = new DateTime(year, 9, 12);
                }
                else
                {
                    programmerDay = new DateTime(year, 9, 13);
                }
            }

            return programmerDay;
        }
    }
}
