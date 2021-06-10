namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class CustomStack<T> : IEnumerable<T>
    {
        private readonly List<T> data;
        public CustomStack()
        {
            this.data = new List<T>();
        }

        public void Push(params T[] inputData)
        {
            this.data.AddRange(inputData);
        }

        public void Pop()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
           
            var lastIndex = this.data.Count - 1;
            this.data.RemoveAt(lastIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
