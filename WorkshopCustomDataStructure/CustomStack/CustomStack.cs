namespace CustomStack
{
    using System;

    public class CustomStack<T>
    {
        const int InitialCapacity = 4;
        private T[] items;
        public CustomStack()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }


        public void ForEach(Action<Object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }
        public T Peek()
        {
            ValidateCollectionElementsCount();
            var lastElement = this.items[this.Count - 1];

            return lastElement;
        }
        public T Pop()
        {
            ValidateCollectionElementsCount();
            var removedElement = this.items[this.Count - 1];
            this.items[this.Count - 1] = default;
            this.Count--;
            Shrink();

            return removedElement;
        }
        public void Push(T element)
        {
            Resize();
            this.Count++;
            this.items[this.Count - 1] = element;
        }
        private void Resize()
        {
            if (!(this.Count == this.items.Length))
            {
                return;
            }

            var tempArray = new T[this.items.Length * 2];
            Array.Copy(this.items, tempArray, this.items.Length);
            this.items = tempArray;
        }

        private void Shrink()
        {
            if (!(this.Count * 4 < this.items.Length))
            {
                return;
            }

            var tempArray = new T[this.items.Length / 4];
            Array.Copy(this.items, tempArray, this.Count);
            this.items = tempArray;
        }

        private void ValidateCollectionElementsCount()
        {
            if (this.Count != 0)
            {
                return;
            }

            throw new InvalidOperationException("Custom stack is empty.");
        }
    }
}
