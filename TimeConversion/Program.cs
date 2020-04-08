using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = timeConversion("07:05:45PM");
            Console.WriteLine(s);
        }

        static string timeConversion(string s)
        {
            string[] time = s.Split(":");
            if(time[time.Length - 1].Contains("PM"))
            {
                if(time[0] != "12")
                {
                    time[0] = (Int32.Parse(time[0]) + 12).ToString();
                }
            }
            else
            {
                if(time[0] == "12")
                {
                    time[0] = "00";
                }
            }

            s = string.Join(":", time);

            return s.Substring(0, 8);
        }
    }
}
