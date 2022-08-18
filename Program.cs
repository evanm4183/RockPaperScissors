using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;

            PrintScore(playerScore, computerScore);
            int userHand = PromptUser();

            Console.WriteLine(userHand);
        }

        static void PrintScore(int score1, int score2)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"| Player: {score1} | Computer: {score2} |");
            Console.WriteLine("------------------------------");
        }

        static int PromptUser()
        {
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            int playedHand = int.Parse(Console.ReadLine());

            return playedHand;
        }
    }
}
