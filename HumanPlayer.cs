using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int response = 0;
            while(response == 0)
            {
                try
                {
                    Console.WriteLine($"Pick a number between 1 and {DiceSize}: ");
                    response = int.Parse(Console.ReadLine());
                    if (response > DiceSize)
                    {
                        Console.WriteLine($"I'm sorry, you must pick a number between 1 and {DiceSize}");
                        response = 0;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine($"I'm sorry, you must input a number between 1 and {DiceSize}");
                }
            }
            
            return response;
        }
    }
}