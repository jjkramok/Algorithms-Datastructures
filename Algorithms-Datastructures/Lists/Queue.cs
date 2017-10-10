using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures.Lists
{
    public class Queue<E> where E : IComparable<E>
    {
        private List<E> q;

        public Queue() {
            q = new List<E>();
        }

        //Adds an element to the queue at the back
        public void Enqueue(E element) {
            q.Add(element);
        }

        //Passes element and removes it from the queue
        public E Dequeue()
        {
            if (q.Count < 1)
                return default(E);
            E first = q[0];
            q.RemoveAt(0);
            return first;
        }

        //Passes element and keeps it enqueued
        public E GetFront() {
            return q[0];
        }

        public bool IsEmpty() {
            return q.Count < 1;
        }
    }
}