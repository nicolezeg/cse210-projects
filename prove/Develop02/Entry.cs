using System;
public class Entry 
{
    public string _dates;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_dates} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}
