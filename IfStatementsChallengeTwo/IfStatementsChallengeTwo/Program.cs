using System;

namespace IfStatementsChallengeTwo
{
    class Program
    {
        // Create global variables
        static int highscore = 300;
        static string highscorePlayer = "Sidney";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the highscore:");
            string userHighscoreString = Console.ReadLine();
            Console.WriteLine("Enter the player's name:");
            string userPlayerName = Console.ReadLine();
            int userHighscore = int.Parse(userHighscoreString);


            CheckHighscore(userHighscore, userPlayerName);

            Console.Read();
        }

        // Create method to check highscore
        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer + ".");
            }
        }
    }
}
