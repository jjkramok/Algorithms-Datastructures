using System;

namespace StrategyPattern
{
    public class SuperHighJump : IJumpStrategy
    {
        public void Jump()
        {
            Console.WriteLine("Super High Jump!");
        }
    }
}