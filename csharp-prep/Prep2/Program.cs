using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade_percent = int.Parse(userInput);

        string letter  = "";

        if (grade_percent >= 93)
        {
            letter = "A";
        }

        if (grade_percent >= 90)
        {
            letter = "A-";
        }

        else if (grade_percent >= 80)
        {
            letter = "B";
        }

        else if (grade_percent >= 70)
        {
            letter = "C";
        }

        else if (grade_percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade_percent >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Sorry, better luck next time!");
        }
    }

}