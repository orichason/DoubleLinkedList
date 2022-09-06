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
                    NodeToInsert.Previous = Head.Previous;
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
            Node<T> Cursor = Head;

            while (Cursor != null)
            {
                if (Cursor.Value.Equals(value))
                {
                    return Cursor;
                }

                Cursor = Cursor.Next;
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

        public bool RemoveLast()
        {
            if (Head == null)
            {
                return false;
            }

            else
            {

                if(Head.Next == null)
                {
                    Head = null;
                    return true;
                }

                Node<T> SecondToLast = Head.Previous.Previous;

                SecondToLast.Next = Head;
                Head.Previous = SecondToLast;
                Count--;
            }

            return true;
        }

        public bool Remove(T value)
        {
            if (Head.Next == null && !Head.Value.Equals(value))
            {
                return false;
            }

            Node<T> Cursor = Head;

            while (!Cursor.Value.Equals(value))
            {
             
                Cursor = Cursor.Next;
            }

            Cursor.Previous.Next = Cursor.Next;
            Cursor.Next.Previous = Cursor.Previous;
            Count--;

            return true;
        }

        public bool IsEmpty()
        {
            if(Head ==  null)
            {
                return true;
            }

            return false;
        }
    }
}
