namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            System.String playerChoice;
            System.String computerChoice;
            int wins = 0;
            int rounds = 0;

            while (playAgain)
            {
                playerChoice = "";
                computerChoice = "";
                while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    playerChoice = Console.ReadLine().ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computerChoice = "ROCK";
                        break;
                    case 2:
                        computerChoice = "PAPER";
                        break;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player chose: " + playerChoice + "\nComputer chose: " + computerChoice);

                switch (playerChoice)
                {
                    case "ROCK":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("It's a tie");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                            wins++;
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("It's a tie");
                        }
                        else if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                            wins++;
                        }
                        break;
                    case "SCISSORS":
                        if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("It's a tie");
                        }
                        else if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                            wins++;
                        }
                        break;

                }
                rounds++;
                if (rounds == 5)
                {
                    Console.WriteLine("Would you like to keep playing? (Y/N)");
                    char answer = Convert.ToChar(Console.ReadLine().ToUpper());
                    while (answer != 'Y' && answer != 'N')
                    {
                        Console.WriteLine("Please enter a valid answer (Y/N)");
                        Console.WriteLine("Do you want to play again?");
                        answer = Convert.ToChar(Console.ReadLine().ToLower());
                    };
                    if (answer == 'N')
                    {
                        playAgain = false;
                        Console.WriteLine("You won " + wins + " times");
                        Console.WriteLine("Thanks for playing");
                    }
                    else
                    {
                        rounds = 0;
                        continue;
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
