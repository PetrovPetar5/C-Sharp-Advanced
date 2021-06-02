using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        public CustomStack()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; private set; }

        public void Push(List<T> elements)
        {
            foreach (var element in elements)
            {
                this.Data.Add(element);
            }
        }

        public T Pop()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            var elementToRemove = this.Data.Last();
            this.Data.Remove(elementToRemove);

            return elementToRemove;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Data.Count - 1; i >= 0; i--)
            {
                yield return this.Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

