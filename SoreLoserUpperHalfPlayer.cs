using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        public override int Roll()
        {
            int diceSizeHalfValue = DiceSize / 2;
            return new Random().Next(diceSizeHalfValue, DiceSize + 1);
        }
    }
}