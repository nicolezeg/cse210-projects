using System;

class Program
{
    static void Main(string[] args)
    {
        var promptGenerator = new PromptGenerator();
        var journal = new Journal();

        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    var prompt = promptGenerator.GetRandomPrompt();
                    Console.Write($"Prompt: {prompt}\nYour Entry: ");
                    var entryText = Console.ReadLine();
                    var newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy/MM/dd"),
                        _promptText = prompt,
                        _entryText = entryText
                    };
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter file name: ");
                    var fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    Console.WriteLine($"Journal saved to {fileName}");
                    break;
                case "4":
                    Console.Write("Enter file name: ");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    Console.WriteLine($"Journal loaded from {fileName}");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}