using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public SmackTalkingPlayer()
        {
            Taunt = "It's a shame you couldn't override yo mama's JankyTeeth() method!";
        }

        public override int Roll()
        {
            Console.WriteLine($"{Name} says '{Taunt}'");
            return new Random().Next(DiceSize) + 1;
        }
    }

    
}