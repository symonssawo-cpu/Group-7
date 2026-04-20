using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int totalScore = 0;
            int secretNumber = 7; 

            Console.WriteLine(" Lucky Number Game!");
            

            // User inputs number of rounds
            Console.Write("Enter the number of rounds you want to play: ");
            int numberOfRounds = int.Parse(Console.ReadLine());

            // Loop through the number of rounds specified
            for (int currentRound = 1; currentRound <= numberOfRounds; currentRound++)
            {
                Console.WriteLine($"\nRound " +currentRound);

                // Ask for the lucky number
                Console.Write("Enter your lucky number: ");
                int luckyNumber = int.Parse(Console.ReadLine());

                // Calculate the remainder
                int remainder = luckyNumber % secretNumber;

                // Display the remainder so the user understands what happened
                Console.WriteLine($"The secret number goes into {luckyNumber} with a remainder of {remainder}.");

                // Apply the game rules based on the remainder
                if (remainder == 0)
                {
                    Console.WriteLine("Result: Draw! (+1 point)");
                    totalScore += 1; // Increment by 1
                }
                else if (remainder % 2 == 0)// If remainder divided by 2 has 0 remainder, it is an even number
                {
                    
                    Console.WriteLine("Result:  WIN! (+3 points)");
                    totalScore += 3; // Increment by 3
                }
                else// If it is neither 0 nor even, it MUST be odd
                {
                    
                    Console.WriteLine("Result: LOSS! (-3 points)");
                    totalScore -= 3; // Decrement by 3
                }

                // Show score at the end of the round
                Console.WriteLine(" Total Score: "+ totalScore);
            }

            // Final game results
                Console.WriteLine("           GAME OVER             ");
                Console.WriteLine("Your Final Score is: "+ totalScore);

            if (totalScore > 0)
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
