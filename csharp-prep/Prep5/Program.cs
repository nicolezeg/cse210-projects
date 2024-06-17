using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    
    
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string myName = Console.ReadLine();

        return myName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int myNumber = int.Parse(Console.ReadLine());

        return myNumber;
    }

    static int SquareNumber(int myNumber)
    {
        int square = myNumber * myNumber;

        return square;
    }

    static void DisplayResult(string myName, int square)
    {
        Console.WriteLine($"Brother {myName}, the square of your number is {square}");
    }
}