using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        private List<string> _tauntList { get; set; }
        public CreativeSmackTalkingPlayer()
        {
            _tauntList = new List<string>()
            {
                "Eugh, your bool StankyBreath variable is set to true!",
                "While(MyOpponentIsDumb) continue. Whoops, that's an infinite loop!",
                "You need to quit implementing that IBigOlLoser interface"
            };            
            Taunt = ReturnRandomTaunt();
        }

        private string ReturnRandomTaunt()
        {
            int insultIndex = new Random().Next(1, _tauntList.Count);

            return _tauntList[insultIndex];
        }

        public override int Roll()
        {
            Console.WriteLine($"{Name} says '{ReturnRandomTaunt()}'");
            return new Random().Next(DiceSize) + 1;
        }
    }
}