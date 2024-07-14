using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        while (true)
        {
            Console.Write("Press enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(1);
                Console.WriteLine(reference.GetDisplayText() + " " + scripture.GetDisplayText());
            }
        }
    }
    
}

