using System;

namespace StrategyPattern
{
    public class HighJump : IJumpStrategy
    {
        public void Jump()
        {
            Console.WriteLine("High Jump!");
        }
    }
}