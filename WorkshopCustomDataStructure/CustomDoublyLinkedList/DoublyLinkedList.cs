namespace CustomDoublyLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {
            this.Count = 0;
        }
        private ListNode<T> head { get; set; }
        private ListNode<T> tail { get; set; }
        private int Count { get; set; }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element);
            }
            else
            {
                var newTail = new ListNode<T>(element);
                newTail.PreviousNode = this.tail;
                this.tail = newTail;
            }

            this.Count++;
        }

        private class ListNode<T>
        {
            public ListNode(T value)
            {
                this.Value = value;
            }
            public ListNode<T> NextNode { get; set; }
            public ListNode<T> PreviousNode { get; set; }
            public T Value { get; set; }
        }
    }
}
