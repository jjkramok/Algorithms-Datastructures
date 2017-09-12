using System;

namespace StrategyPattern
{
    public class NormalJump : IJumpStrategy
    {
        public void Jump()
        {
            Console.WriteLine("Normal Jump!");
        }
    }
}