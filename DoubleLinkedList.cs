using System;
namespace DoubleLinkedList
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Head;
        public int Count { get; set; }


        public void AddFirst(T value)
        {
            if (Head == null)
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

        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
            }

            else
            {
                if (Head.Next == null)
                {
                    Node<T> NodeToInsert = new Node<T>(value);
                    Head.Next = NodeToInsert;
                    NodeToInsert.Next = Head;
                    Head.Previous = NodeToInsert;
                    NodeToInsert.Previous = Head;
                }
                else
                {
                    Node<T> NodeToInsert = new Node<T>(value);
                    Head.Previous.Next = NodeToInsert;
                    NodeToInsert.Next = Head;
                    NodeToInsert.Previous = Head.Previous.Previous;
                    Head.Previous = NodeToInsert;
                }

            }
            Count++;
        }

        public void AddBefore(Node<T> node, T value)
        {
            Node<T> Cursor = Head;

            while (Cursor != node)
            {
                Cursor = Cursor.Next;
            }

            Node<T> OldPrevious = Cursor.Previous;

            Node<T> NewNode = new Node<T>(value);
            Cursor.Previous = NewNode;
            NewNode.Next = Cursor;
            OldPrevious.Next = NewNode;
            NewNode.Previous = OldPrevious;
            Count++;

        }

        public void AddAfter(Node<T> node, T value)
        {
            Node<T> Cursor = Head;

            while (Cursor != node)
            {
                Cursor = Cursor.Next;
            }

            Node<T> OldNext = Cursor.Next;

            Node<T> NewNode = new Node<T>(value);
            Cursor.Next = NewNode;
            NewNode.Previous = Cursor;
            OldNext.Next = NewNode;
            NewNode.Next = OldNext;
            Count++;
        }

        public Node<T> Search(T value)
        {
            Node<T> cursor = Head;

            while (cursor != null)
            {
                if (cursor.Value.Equals(value))
                {
                    return cursor;
                }

                cursor = cursor.Next;
            }

            return null;
        }

        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }

            else
            {
                if (Head.Next == null)
                {
                    Head = null;
                }
                Head.Next.Previous = Head.Previous;
                Head = Head.Next;
                Count--;
            }

            return true;
        }
    }
}
