using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 50)
    {
        _prompts = new List<string>
        {
            "-----Think of a time when you stood up for someone else.-----",
            "-----Think of a time when you did something really difficult.-----",
            "-----Think of a time when you helped someone in need.-----",
            "-----Think of a time when you did something truly selfless.-----"
        };

        _questions = new List<string>
        {
            "-----Why was this experience meaningful to you?-----",
            "-----Have you ever done anything like this before?-----",
            "-----How did you get started?-----",
            "-----How did you feel when it was complete?-----",
            "-----What made this time different than other times when you were not as successful?-----",
            "-----What is your favorite thing about this experience?-----",
            "-----What could you learn from this experience that applies to other situations?-----",
            "-----What did you learn about yourself through this experience?-----",
            "-----How can you keep this experience in mind in the future?-----"            
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        DisplayPrompt(prompt);
        string question = GetRandomQuestion();
        DisplayQuestions(question);
        ShowSpinner(3);
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
        Console.WriteLine("Take a moment to think about this...");
        Console.WriteLine();
    }

    private void DisplayQuestions(string question)
    {
        Console.WriteLine("Now, consider this question:");
        Console.WriteLine(question);
        Console.WriteLine("Take your time to reflect on this...");
        Console.WriteLine();
    }
}
