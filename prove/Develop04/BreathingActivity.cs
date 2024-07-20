using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private readonly int _duration;

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 50)
    {
        _duration = 0;
    }

    public override void Run()
    {

        DisplayStartingMessage();
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
    }
}