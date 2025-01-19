using System;

namespace Calculator.ChooseCalculation
{
    public class UserChoice
    {
        public static void PerformCalculation(string userName)
        {
            Console.WriteLine("\nWhich operation would you like to perform?");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");

            Console.Write("\nEnter the number corresponding to the operation: ");

            int userInput = int.Parse(Console.ReadLine());
            string userChoice = " ";

            switch (userInput)
            {
                case 1:
                    userChoice = "Addition";
                    break;
                case 2:
                    userChoice = "Subtraction";
                    break;
                case 3:
                    userChoice = "Multiplication";
                    break;
                case 4:
                    userChoice = "division";
                    break;
                default:
                    userChoice = "Default";
                    break;
            }
            Console.Clear();

            string FinalUserChoice = $"Okay {userName}, you chose to perform {userChoice}.";
            Console.WriteLine(FinalUserChoice);
        }
    }
}
