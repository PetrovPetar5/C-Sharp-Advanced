namespace Froggy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Lake : IEnumerable<int>
    {
        private readonly List<int> stoneNumbers;
        public Lake(params int[] data)
        {
            this.stoneNumbers = new List<int>(data);
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (this.stoneNumbers.Count == 0)
            {
                throw new InvalidOperationException("The collection is empty.");
            }

            for (int i = 0; i < this.stoneNumbers.Count; i += 2)
            {
                yield return this.stoneNumbers[i];
            }

            var stonesEvenPosMaxCount = this.stoneNumbers.Count % 2 == 0 ? this.stoneNumbers.Count - 1 : this.stoneNumbers.Count - 2;
            for (int i = stonesEvenPosMaxCount; i >= 0; i -= 2)
            {
                yield return this.stoneNumbers[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
