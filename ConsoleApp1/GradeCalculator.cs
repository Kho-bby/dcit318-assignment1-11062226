using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter a numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        { 
            string letterGrade;

            if (grade >= 90 && grade <= 100)
            {
                letterGrade = "A";
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = "B";
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = "C";
            }
            else if (grade >= 60 && grade <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}