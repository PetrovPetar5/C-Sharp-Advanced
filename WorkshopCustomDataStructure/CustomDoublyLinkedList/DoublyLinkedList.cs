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
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new NullReferenceException("The list is empty");
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("The List is empty.");
            }

            var lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;
            return lastElement;
        }

        public T[] ToAarray()
        {
            var arrayT = new T[this.Count];
            var counter = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                arrayT[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }

            return arrayT;
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
