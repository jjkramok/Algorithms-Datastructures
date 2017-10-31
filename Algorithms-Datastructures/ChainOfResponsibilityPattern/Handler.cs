namespace ChainOfResponsibilityPattern
{
    // Abstract Handler
    public abstract class Handler
    {
        private Handler sucessor;

        public abstract void HandleRequest(int request);
    }
}