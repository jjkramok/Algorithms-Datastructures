using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dice dicebag = new Dice();
            dicebag.AddDie(new D4());
            dicebag.AddDie(new D4());
            dicebag.AddDie(new D6());
            dicebag.AddDie(new D20());
            Console.WriteLine(dicebag.Roll());
        }
    }
}