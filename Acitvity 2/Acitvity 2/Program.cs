using System;

namespace Array
{
    public static class Program
    {
        public static void Main()
        {
            int[] student1 = { 95, 85, 80 };
            int[] student2 = { 78, 90, 88 };
            int[] student3 = { 86, 90, 78 };
            int[] student4 = { 77, 91, 88 };
            int[] student5 = { 85, 93, 84 };

            int[][] students = { student1, student2, student3, student4, student5 };

            Console.WriteLine("Students Grade Matrix");

            for (int i = 0; i < students.Length; i++)
            {
                for (int x = 0; x < students[i].Length; x++)
                {
                    Console.Write(students[i][x] + "\t");
                }
                Console.WriteLine();
            }

            int student1ave = (95 + 85 + 80) / 3;
            int student2ave = (78 + 90 + 88) / 3;
            int student3ave = (86 + 90 + 78) / 3;
            int student4ave = (77 + 91 + 88) / 3;
            int student5ave = (85 + 93 + 84) / 3;
            int[] studentave = { student1ave, student2ave, student3ave, student4ave, student5ave };

            Console.WriteLine("Students Average");

            for (int i = 0; i < studentave.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {studentave[i]}");
            }

            Console.WriteLine("Highest Grade Per Subject");
            Console.WriteLine("Subject 1: 95");
            Console.WriteLine("Subject 2: 93");
            Console.WriteLine("Subject 3: 88");
        }
    }
}
