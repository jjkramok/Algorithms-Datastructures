using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Observable
    {
        private HashSet<IObserver> observers = new HashSet<IObserver>();

        public bool attach(IObserver obs)
        {
            return observers.Add(obs);
        }

        public bool detach(IObserver obs)
        {
            return observers.Remove(obs);
        }

        public void notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}