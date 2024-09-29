using System;

public class PromptGenerator
{
    private List <string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {          
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I looking forward to tomorrow?",
            "What did I learn today?",
            "What am I grateful for today?",
            "What was the most challenging part of my day?"
        };
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}