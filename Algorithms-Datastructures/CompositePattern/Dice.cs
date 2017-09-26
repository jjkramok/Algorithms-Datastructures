using System.Collections.Generic;

namespace CompositePattern
{
    public class Dice : Die
    {
        private HashSet<Die> dice;

        public Dice()
        {
            dice = new HashSet<Die>();
        }

        public void AddDie(Die d)
        {
            dice.Add(d);
        }

        public void RemoveDie(Die d)
        {
            dice.Remove(d);
        }
        
        public int Roll()
        {
            var total = 0;
            foreach (var die in dice)
            {
                total += die.Roll();
            }
            return total;
        }
    }
}