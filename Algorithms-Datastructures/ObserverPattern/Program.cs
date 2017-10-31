namespace ObserverPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mailbox box = new Mailbox();
            Observer obs0;
            box.attach(obs0 = new Observer());
            box.attach(new Observer());
            box.attach(new Observer());
            box.notify();
            box.detach(obs0);
            box.notify();
        }
    }
}