
namespace DecoratorPattern
{
    //Concrete Component
    public class Coffee : Beverage
    {
        public override double CalculatePrice()
        {
            return 1.0;
        }
    }
}