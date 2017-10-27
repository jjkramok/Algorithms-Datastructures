using System;

namespace Algorithms_Datastructures.Lists
{
    public class SinglyLinkedList<T> where T : IComparable<T>
    {
        private Node<T> _head;

    public void addFront(T data) {
        Node<T> newNode = new Node<T>(data);
        newNode.setNext(_head);
        _head = newNode;
    }

    /**
     * Appends new data to the end of the list by updating the last node his pointer
     * @param data
     */
    public void append(T data) {
        Node<T> newNode = new Node<T>(data);
        newNode.setNext(null);
        if (_head == null) {
            this._head = newNode;
        } else {
            Node<T> current = _head;
            while (current.getNext() != null) {
                current = current.getNext();
            }
            current.setNext(newNode);
        }
    }

    public void removeLast() {
        if (_head == null) {
            return;
        }
        Node<T> current = _head;
        while (current.getNext().getNext() != null) {
            current = current.getNext();
        }
        current.setNext(null);
    }

    public void add(int index, T data) {
        Node<T> newNode = new Node<T>(data);
        if (_head == null) {
            this._head = newNode;
            return;
        }

        Node<T> current = _head;
        for (int i = 0; i < index; i++) {
            if (i + 1 == index) {
                Node<T> temp = current.getNext();
                current.setNext(newNode);
                newNode.setNext(temp);
                break;
            }

            if (current.getNext() == null) {
                current.setNext(newNode);
                break;
            }

            current = current.getNext();
        }
    }

        public Node<T> GetFront()
        {
            return _head;
        }

        public Node<T> GetLast()
        {
            if (_head == null)
                return null;
            Node<T> last = _head;
            while (last.getNext() != null)
            {
                last = last.getNext();
            }
            return last;
        }

        public int Length()
        {
            int size = 0;
            if (_head == null)
                return size;
            Node<T> node = _head;
            size++;
            while (node.getNext() != null)
            {
                size++;
                node = node.getNext();
            }
            return size;
        }

    /**
    public void reverse<T>() {
        //Empty and single node lists are useless for this operation
        if (_head == null || _head.getNext() == null)
            return;

        Stack<Node<T>> reverse = new Stack<Node<T>>();
        Node<T> current = _head;
        while(current != null) {
            //System.out.print(current.data);
            reverse.Push(current);
            if (current.getNext() == null)
                break;
            current = current.getNext();
        }
        //System.out.println(" <-- in stack");
        _head = reverse.Pop();
        current = _head;
        Node<T> currentPop = reverse.Pop();
        while(currentPop != null) {
            current.setNext(new Node<T>(currentPop.data));     //Set last pop as new SLL node
            current = current.getNext();                    //Go to the new last node of the SLL structure (to insert new node in the next iteration)
            currentPop = reverse.Pop();                     //Take the TOS for this iteration
        }
    }
    */

    public override String ToString() {

        String result = "";

        for (Node<T> current = _head; current != null; current = current.getNext()) {
            result = result + current + "";
        }
        return result;
    }

    public class Node<T> {
        public T data;
        private Node<T> next;

        public Node(T data) {
            this.data = data;
        }

        public Node<T> getNext() {
            return next;
        }

        public void setNext(Node<T> next) {
            this.next = next;
        }

        public override string ToString() {
                return data + "";
        }
    }
    }
}