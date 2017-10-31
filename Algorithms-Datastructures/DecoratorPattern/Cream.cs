namespace DecoratorPattern
{
    public class Cream : Decorator
    {
        private new double Price = 0.15;
        
        public Cream(Beverage parent) : base(parent)
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + Price;
        }
    }
}