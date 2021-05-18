namespace BoxOfT
{
    using System.Collections.Generic;
    public class Box<T>
    {
        private Stack<T> elements;

        public Box()
        {
            elements = new Stack<T>();
        }
        public int Count
        {
            get
            {
                return elements.Count;
            }
        }

        public void Add(T element)
        {
            this.elements.Push(element);
        }

        public T Remove()
        {
            return this.elements.Pop();
        }
    }
}
