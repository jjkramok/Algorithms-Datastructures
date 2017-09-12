namespace StrategyPattern
{
    public abstract class Character
    {
        public IJumpStrategy Jumpstrategy { get; set; } = new NormalJump();

        public void DoJump()
        {
            Jumpstrategy.Jump();
        }
    }
}