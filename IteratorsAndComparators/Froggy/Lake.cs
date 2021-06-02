using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly int[] data;
        public Lake(params int[] collection)
        {
            this.data = collection;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.data.Length; i += 2)
            {
                yield return this.data[i];
            }

            for (int i = this.data.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.data[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
