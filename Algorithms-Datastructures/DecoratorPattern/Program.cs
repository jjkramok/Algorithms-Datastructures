using System;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Beverage coffee = new Cream(new Cream(new Sugar(new Coffee())));
            Console.WriteLine("Price of beverage: {0} $", coffee.CalculatePrice());
        }
    }
}