namespace StrategyPattern
{
    public class Player : Character
    {
        public void DoJump()
        {
            jumpstrategy.Jump();
        }
    }
}