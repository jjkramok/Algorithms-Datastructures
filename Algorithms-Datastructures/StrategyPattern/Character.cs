namespace StrategyPattern
{
    public abstract class Character
    {
        public IJumpStrategy Jumpstrategy { get; set; }
        
        public void DoJump()
        {
            Jumpstrategy.Jump();
        }
    }
}