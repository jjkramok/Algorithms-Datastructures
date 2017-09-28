using System;

namespace Algorithms_Datastructures.Lists
{
    public class Stack<T> where T : IComparable<T>
    {
        private Node _tos; //top of stack

        public void Push(T data) {
            _tos = new Node(data, this._tos);
        }

        public T Pop() {
            T tosData = default(T);
            if (_tos != null) {
                tosData = _tos.data;
                _tos = _tos.next;
            }
            return tosData;
        }

        public T GetTos() {
            return this._tos.data;
        }

        public Boolean IsEmpty() {
            if (_tos == null) {
                return true;
            }
            return false;
        }

        public void Print() {
            Node current = this._tos;
            while(current != null) {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine();
        }

        protected class Node {
            public T data;
            public Node next;

            public Node(T data, Node next) {
                this.data = data;
                this.next = next;
            }
        }
    }
}