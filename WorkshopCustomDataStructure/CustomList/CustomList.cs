namespace CustomList
{
    using System;
    public class CustomList<T>
    {
        const int InitialCapacity = 2;
        private T[] items;

        public CustomList()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count
        {
            get;
            private set;
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);

                return this.items[index];
            }
            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            }
        }

        public void Reverse()
        {
            for (int i = 0; i < this.Count / 2; i++)
            {
                var temp = this.items[i];
                this.items[i] = this.items[this.Count - 1 - i];
                this.items[this.Count - 1 - i] = temp;
            }
        }

        public int Find(T element)
        {
            var elementIndex = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.items[i]))
                {
                    elementIndex = i;
                }
            }

            return elementIndex;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);
            var temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }
        public bool Contains(T element)
        {
            var contained = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (!(this.items[i].Equals(element)))
                {
                    continue;
                }

                contained = true;
            }

            return contained;
        }
        public void Insert(int index, T element)
        {
            ValidateIndex(index);
            ResizeCheck();
            ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            ValidateIndex(index);
            var removedElement = this.items[index];
            this.items[index] = default;
            Shift(index);
            this.Count--;
            Shrink();

            return removedElement;
        }
        public void Add(T element)
        {
            ResizeCheck();

            this.items[this.Count] = element;
            this.Count++;
        }

        private void ResizeCheck()
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }
        }

        private void Resize()
        {
            var tempArray = new T[this.items.Length * 2];
            Array.Copy(this.items, tempArray, this.items.Length);
            this.items = tempArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.Count - 1] = default;
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

        private void ShiftToRight(int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                var temp = this.items[i];
                this.items[i + 1] = temp;
                this.items[i] = default;
            }
        }
        private void ValidateIndex(int index)
        {
            if (index >= this.Count || 0 > index)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
