using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.DoJump();
            player1.Jumpstrategy = new HighJump();
            player1.DoJump();

            Console.ReadKey();
        }
    }
}