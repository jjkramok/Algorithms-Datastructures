using System;

namespace StrategyPattern
{
    public class NoJump : IJumpStrategy
    {
        public void Jump()
        {
            Console.WriteLine("No Jump!");
        }
    }
}