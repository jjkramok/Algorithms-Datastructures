using System;

namespace DecoratorPattern
{
    // Concrete Decorator
    public class Sugar : Decorator
    {
        private new double Price = 0.3;
        
        public Sugar(Beverage parent) : base(parent)
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + Price;
        }
    }
}