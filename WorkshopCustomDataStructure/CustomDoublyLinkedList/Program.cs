namespace CustomDoublyLinkedList
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(55);
            list.AddLast(2);
            list.AddLast(5);
            
        }
    }
}
