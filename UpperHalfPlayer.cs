using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int diceSizeHalfValue = DiceSize / 2;
            return new Random().Next(diceSizeHalfValue, DiceSize + 1);
        }
    }
}