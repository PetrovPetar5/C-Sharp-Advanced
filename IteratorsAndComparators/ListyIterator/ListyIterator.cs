using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        public ListyIterator(ICollection<T> collection)
        {
            this.Data = collection.ToList();
        }

        public List<T> Data { get; private set; }
        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index + 1 == this.Data.Count)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.Data[this.index]);
        }

        public string PrintAll()
        {
            var result = String.Join(" ", this.Data);
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.Data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
