using System;

namespace TestTime
{
    struct Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }


        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            Normalize();
        }

        public Time(int totalSeconds)
        {
            Hour = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minute = totalSeconds / 60;
            Second = totalSeconds % 60;
        }

        private void Normalize()
        {
            int totalSeconds = Hour * 3600 + Minute * 60 + Second;
            if (totalSeconds < 0) totalSeconds = 0;
            Hour = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minute = totalSeconds / 60;
            Second = totalSeconds % 60;
        }


        public static Time operator +(Time t1, Time t2)
        {
            int totalSeconds = t1.ToTotalSeconds() + t2.ToTotalSeconds();
            return new Time(totalSeconds);
        }


        public static Time operator -(Time t1, Time t2)
        {
            int totalSeconds = t1.ToTotalSeconds() - t2.ToTotalSeconds();
            return new Time(totalSeconds);
        }

        private int ToTotalSeconds()
        {
            return Hour * 3600 + Minute * 60 + Second;
        }

        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 45, 30);
            Time t2 = new Time(0, 20, 45);

            Time sum = t1 + t2;
            Time diff = t1 - t2;

            Time fromSeconds = new Time(7265);

            Console.WriteLine("Time 1: " + t1);
            Console.WriteLine("Time 2: " + t2);
            Console.WriteLine("Sum:    " + sum);
            Console.WriteLine("Diff:   " + diff);
            Console.WriteLine("From Seconds (7265): " + fromSeconds);
        }
    }
}
