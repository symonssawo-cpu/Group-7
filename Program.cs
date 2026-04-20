using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int TotalScore = 0;
            int SecretNumber = 7; 

            Console.WriteLine(" Lucky Number Game!");
            

            // User inputs number of rounds
            Console.Write("Enter the number of rounds you want to play: ");
            int NumberOfRounds = int.Parse(Console.ReadLine());

            // Loop through the number of rounds specified
            for (int CurrentRound = 1; CurrentRound <= NumberOfRounds; CurrentRound++)
            {
                Console.WriteLine($"\nRound " +CurrentRound);

                // Ask for the lucky number
                Console.Write("Enter your lucky number: ");
                int LuckyNumber = int.Parse(Console.ReadLine());

                // Calculate the remainder
                int remainder = LuckyNumber % SecretNumber;

                // Display the remainder 
                Console.WriteLine($"The remainder is {remainder}.");

                // Apply the game rules based on the remainder
                if (remainder == 0)
                {
                    Console.WriteLine("Result: Draw! (+1 point)");
                    TotalScore += 1; 
                }
                else if (remainder % 2 == 0)//even number
                {
                    
                    Console.WriteLine("Result:  WIN! (+3 points)");
                    TotalScore += 3; 
                }
                else// its an odd number
                {
                    
                    Console.WriteLine("Result: LOSS! (-3 points)");
                    TotalScore -= 3; 
                }

                // Show score at the end of the round
                Console.WriteLine("\n Total Score: "+ TotalScore);
            }

            // Final game results
                Console.WriteLine("  \n GAME OVER  ");
                Console.WriteLine("Your Final Score is: "+ TotalScore);

            if (TotalScore > 0)
            {
                Console.WriteLine(" YOU WIN! ");
            }
            else
            {
                Console.WriteLine(" YOU LOSE. ");
            }

             Console.ReadLine();
        }
    }
}
