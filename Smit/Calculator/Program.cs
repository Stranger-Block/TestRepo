using Calculator.ChooseCalculation;
using Calculator.Greetings;

public class Program
{
    private static void Main(string[] args)
    {
        string userName = UserGreetings.GetGreeting();

        Console.Write("\nPress any key to start the calculation...");
        Console.ReadKey();
        Console.Clear();

        UserChoice.PerformCalculation(userName);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
