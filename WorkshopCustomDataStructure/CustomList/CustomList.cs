namespace CustomList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
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
                this.items[index] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Resize()
        {
            if (this.items.Length <= this.Count)
            {
                return;
            }

            var tempArray = new T[this.items.Length * 2];
            Array.Copy(this.items, tempArray, this.items.Length);
            this.items = tempArray;
        }
    }
}
