using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var StudentNames = new List<string>();
            var StudentGrades = new List<int>();

            var Adding = true;

            while(Adding)
            {
                Console.WriteLine("Student Name: ");
                StudentNames.Add(Console.ReadLine());

                Console.WriteLine("Student Grade: ");
                StudentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    Adding = false;
            }

            for (int i = 0; i < StudentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", StudentNames[i], StudentGrades[i]);
            }
        }
    }
}
