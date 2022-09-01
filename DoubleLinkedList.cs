using System;
namespace DoubleLinkedList
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Head;
        public int Count { get; set; }


        public void AddFirst (T value)
        {
            if(Head == null)
            {
                Head = new Node<T>(value);
            }

            else
            {
                Node<T> NodeToInsert = new Node<T>(value);
                Head.Previous = NodeToInsert;
                NodeToInsert.Next = Head;
                Head = NodeToInsert;
            }

            Count++;
        }

        public void AddLast (T value)
        {
            if(Head == null)
            {
                Head = new Node<T>(value);
            }

            else
            {
                Node<T> NodeToInsert = new Node<T>(value);
                Head.Previous = NodeToInsert;
                NodeToInsert.Next = Head;
            }
            Count++;
        }

        public void AddBefore (Node<T> node, T value)
        {
            Node<T> Cursor = Head;

            while (Head.Next != Head)
            {
                if(Cursor == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    Cursor.Previous = NewNode;
                    NewNode.Next = Cursor;
                    Count++;
                }
            }

        }

        public void AddAfter (Node<T> node, T value)
        {
            Node<T> Cursor = Head;

            while (Head.Next != Head)
            {
                if (Cursor == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    NewNode.Next = node.Next;
                    node.Next = NewNode;
                    Count++;
                }
            }
        }
    }
}
