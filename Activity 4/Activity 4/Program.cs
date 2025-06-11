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
            return String.Format("{0:D2}:{1:D2}", Hour, Minute);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time morning = new Time(8, 30, 0);
            Time noon = new Time(12, 0, 0);
            Time evening = new Time(18, 45, 15);

            Console.WriteLine("Morning Time: " + morning);
            Console.WriteLine("Noon Time: " + noon);
            Console.WriteLine("Evening Time: " + evening);
        }
    }
}
