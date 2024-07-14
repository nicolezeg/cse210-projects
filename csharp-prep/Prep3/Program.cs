class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ")
        // int magicNumber = int Parse(Console.ReadLine())

        string response = "yes";
        while (response == "yes")
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 71);
            int guess = -1;
            
    
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
    
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
    
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
    
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Do you want to continue? ");
                    response = Console.ReadLine();
                }
            }
        }
    }
}