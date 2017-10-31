using System;

namespace DecoratorPattern
{
    // Abstract Decorator
    public abstract class Decorator : Beverage
    {
        public Beverage Parent;
        public Double Price = 0;

        public Decorator(Beverage parent)
        {
            Parent = parent;
        }

        public override double CalculatePrice()
        {
            if (Parent != null)
                return Price + Parent.CalculatePrice();
            return Price;
        }

    }
}