namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    public class Box<T>
    {
        private Stack<T> collection;

        public Box()
        {
            this.collection = new Stack<T>();
        }

        public int Count => this.collection.Count;
        public void Add(T element)
        {
            this.collection.Push(element);
        }
        public T Remove()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentNullException("You cannot remove from an empty collection.");
            }

            return this.collection.Pop();
        }
    }
}
