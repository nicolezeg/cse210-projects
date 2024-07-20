using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 50)
    {
        _count = 0;
        _prompts = new List<string>
        {
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "When have you felt the Holy Ghost this month?",
           "Who are some of your personal heroes?" 
        };

    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountdown(5);
        List<string> userList = GetListFromUser();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("List as many items as you can (Type 'done' to finish):");
        _count = userList.Count;

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            userList.Add(input);
        }
    
        Console.WriteLine($"You listed {_count} items.");
        return userList;
    }
}


