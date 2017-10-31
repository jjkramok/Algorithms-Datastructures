using System;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Observer received update.");
        }
    }
}