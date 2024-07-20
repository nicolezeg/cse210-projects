using System; 
using System.Collections.Generic;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public abstract void Run();

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("You did a great job!");
        Console.WriteLine($"You completed {_name} in {_duration} seconds.");
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            System.Threading.Thread.Sleep(seconds * 1000);
        }
        Console.WriteLine();
    }
}
