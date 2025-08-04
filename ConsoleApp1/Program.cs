
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an application");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice (0-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GradeCalculator.Run();
                break;
           
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 0 and 3.");
                break;
        }
    }
}