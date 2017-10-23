using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures.Lists
{
    public class Queue<E> where E : IComparable<E>
    {
        private E[] _q;
        private int _i;

        public Queue() {
            _q = new E[10];
            _i = 0;
        }

        //Adds an element to the queue at the back
        public void Enqueue(E element)
        {
            _q[_i] = element;
            if (_i == _q.Length-1)
                IncreaseQueueSize();
            _i++;
        }

        //Passes element and removes it from the queue
        public E Dequeue()
        {
            if (_q.Length < 1)
                return default(E);
            E first = _q[0];
            Array.Copy(_q, 1, _q, 0, --_i);
            return first;
        }

        //Passes element and keeps it enqueued
        public E GetFront() {
            return _q[0];
        }

        public bool IsEmpty() {
            return _q.Length < 1;
        }
        
        private void IncreaseQueueSize()
        {
            E[] res = new E[_q.Length * 2];
            for (int i = 1; i < _q.Length; i++)
            {
                res[i] = _q[i];
            }
            _q = res;
        }

        public E[] getQueue()
        {
            return _q;
        }

        public override string ToString()
        {
            string res = "[";
            bool first = true;
            for (int i = 1; i < _i; i++)
            {
                if (!first)
                {
                    res += ", ";
                }
                res += _q[i];
                first = false;

            }
            return res;
        }
    }
}