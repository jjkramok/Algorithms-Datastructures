using System;

namespace Algorithms_Datastructures.Lists
{
    public class FCNS<T> where T : IComparable<T>
    {
        T data;
        FCNS<T> firstChild;
        FCNS<T> nextSibling;

        public FCNS() {}

        public FCNS(T data) {
            this.data = data;
        }

        public FCNS(T data, FCNS<T> child, FCNS<T> sibling) {
            this.data = data;
            this.firstChild = child;
            this.nextSibling = sibling;
        }

        public void printPreOrder() {
            if (data != null) {
                Console.Write(data);
                Console.Write("\t");
            } else {
                Console.Write("(...)\t");
            }
            if (firstChild != null)
                firstChild.printPreOrder();
            if (nextSibling != null) {
                Console.WriteLine("\n");
                nextSibling.printPreOrder();
            }
        }

        public T getData() {
            return data;
        }

        public void setData(T data) {
            this.data = data;
        }

        public FCNS<T> getFirstChild() {
            return firstChild;
        }

        public void setFirstChild(FCNS<T> firstChild) {
            this.firstChild = firstChild;
        }

        public FCNS<T> getNextSibling() {
            return nextSibling;
        }

        public void setNextSibling(FCNS<T> nextSibling) {
            this.nextSibling = nextSibling;
        }
    }
}