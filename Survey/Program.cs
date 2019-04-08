using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born in: {0}", month);

            if (month == "September")
            {
                Console.WriteLine("You are a Virgo");
            }
            else if (month == "July")
            {
                Console.WriteLine("You are a Cancer");
            }
            else if (month == "May")
            {
                Console.WriteLine("You are a Taurus");
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("Field cannot be left blank. Try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
