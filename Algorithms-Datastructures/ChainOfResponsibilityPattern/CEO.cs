using System;

namespace ChainOfResponsibilityPattern
{
    // Concrete Handler
    public class CEO : Handler
    {
        private Handler _sucessor;
        
        public CEO(Handler suc)
        {
            _sucessor = suc;
        }
        
        public override void HandleRequest(int request)
        {
            Console.WriteLine("Request {1} handled by {0}", GetType().Name, request);
        }
    }
}