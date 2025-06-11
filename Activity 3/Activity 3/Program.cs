using System;

namespace TestTime
{
    class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time morning = new Time(5, 30, 0);
            Time noon = new Time(12, 0, 0);
            Time evening = new Time(18, 45, 15);

            Console.WriteLine("Morning Time: " + morning);
            Console.WriteLine("Noon Time: " + noon);
            Console.WriteLine("Evening Time: " + evening);
        }
    }
}
