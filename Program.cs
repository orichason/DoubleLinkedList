using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddLast(10);
            doubleLinkedList.AddLast(20);
            doubleLinkedList.AddBefore(doubleLinkedList.Search(10), 40);
            doubleLinkedList.AddAfter(doubleLinkedList.Search(10), 60);
            doubleLinkedList.RemoveFirst();
            ;
        }
    }
}
