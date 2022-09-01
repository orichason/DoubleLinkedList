using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(10);
            doubleLinkedList.AddLast(20);   
            ;
        }
    }
}
