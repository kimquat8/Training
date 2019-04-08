using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentGrades = new int[] { 80, 77, 65, 100, 98, 42, 90, 12, 55, 96 };

            foreach (var StudentGrade in StudentGrades)
            {
                Console.WriteLine(StudentGrade);
            }
            
        }
    }
}
