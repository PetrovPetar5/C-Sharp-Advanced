namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class ListyIterator<T>
    {
        private readonly List<T> collection;
        private int index;
        public ListyIterator(params T[] inputCollection)
        {
            this.collection = new List<T>(inputCollection);
            this.index = 0;
        }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }

            this.index++;
            return true;
        }

        public bool HasNext()
        {
            var hasNext = this.index + 1 < this.collection.Count;

            return hasNext;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[this.index]);
        }
    }
}
