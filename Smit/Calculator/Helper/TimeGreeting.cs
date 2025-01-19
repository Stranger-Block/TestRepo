using System;

namespace Calculator.Helper
{
    public class TimeGreeting
    {
        public static string GetTimeBasedGreeting(string userName)
        {
            int currentHour = DateTime.Now.Hour;

            string greeting = currentHour switch
            {
                >= 0 and < 12 => "Good Morning",
                >= 12 and < 16 => "Good Afternoon",
                >= 16 and <= 23 => "Good Evening",
                _ => "Hello"
            };

            return $"\n\nHello {userName}, {greeting}...!!!";
        }
    }
}
