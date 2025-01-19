using Calculator.Helper;
using System;

namespace Calculator.Greetings
{
    public class UserGreetings
    {
        public static string GetGreeting()
        {
            Console.Write("\nEnter your name: ");
            string? name = Console.ReadLine()?.Trim();

            Console.Clear();

            //if (string.IsNullOrEmpty(name))
            //{
            //    name = "User"; // Default name if no input is given
            //}

            string greetingMessage = TimeGreeting.GetTimeBasedGreeting(name);
            Console.WriteLine(greetingMessage);

            return name;
        }
    }
}
