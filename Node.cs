using System;
namespace DoubleLinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Previous;
        public Node<T> Next;


        public Node(T value)
            : this(value, null, null) { }

        public Node(T value, Node<T> previous, Node<T> next)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }
}
