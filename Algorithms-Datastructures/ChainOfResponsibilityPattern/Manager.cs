using System;

namespace ChainOfResponsibilityPattern
{
    // Concrete Handler
    public class Manager : Handler
    {
        private Handler _sucessor;
        
        public Manager(Handler suc)
        {
            _sucessor = suc;
        }
        
        public override void HandleRequest(int request)
        {
            if (request < 10000)
            {
                Console.WriteLine("Request {1} handled by {0}", GetType().Name, request);
            }
            else
            {
                Console.WriteLine("Request {1} NOT handled by {0}. Sent to {2}", GetType().Name, request, _sucessor.GetType().Name);
                _sucessor.HandleRequest(request);
            }
        }
    }
}