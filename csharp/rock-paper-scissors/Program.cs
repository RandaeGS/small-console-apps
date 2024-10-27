namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            string[] options = { "rock", "paper", "scissors" };
            Random rnd = new();

            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("Write your choice (rock, paper or scissors)");
            string userChoice = Console.ReadLine().ToLower();

            if (!options.Contains(userChoice))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int computerIndex = rnd.Next(options.Length);
            string computerChoice = options[computerIndex];

            Console.WriteLine($"Computer chose {computerChoice}");

            if (computerChoice == userChoice)
            {
                Console.WriteLine("It is a draw!");
                return;
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                                 (userChoice == "paper" && computerChoice == "rock") ||
                                 (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}

