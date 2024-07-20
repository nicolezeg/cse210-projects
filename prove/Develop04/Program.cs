using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.Run();   

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
    
            // foreach (string s in animationStrings)
            // {
            //     Console.Write(s);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }
    
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);
    
            int i = 0;
    
            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
    
                i++;
    
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
        }
    }
}