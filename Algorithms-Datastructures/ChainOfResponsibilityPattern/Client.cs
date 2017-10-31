namespace ChainOfResponsibilityPattern
{
    public class Client
    {
        public Handler handler { get; set;}

        public Client()
        {
            handler = new Chief(new Manager(new CEO(null)));
        }

        public void Do(int request)
        {
            handler.HandleRequest(request);
        }
    }
}