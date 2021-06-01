namespace Box
{
    using System;
    using System.Collections.Generic;
    public class Box<T> where T : IComparable
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; }


        public static void Swap(int[] indiceInput, List<Box<T>> collection)

        {
            var indiceCount = indiceInput.Length;
            if (indiceCount == 0 || indiceCount == 1)
            {
                throw new ArgumentOutOfRangeException("There are not enough elements to be switched");
            }

            var firstIndex = indiceInput[0];
            var secondIndex = indiceInput[1];

            var isValidFirstIndex = firstIndex >= 0 && firstIndex <= collection.Count - 1;
            var isValidSecondIndex = secondIndex >= 0 && secondIndex <= collection.Count - 1;

            if (!(isValidFirstIndex && isValidSecondIndex))
            {
                new ArgumentException("Index out of bounds of the array");
            }

            var temp = collection[firstIndex];

            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = temp;
        }

        public static int CountGreaterElements(List<T> collection, T comparator)
        {
            var count = 0;
            foreach (var item in collection)
            {
                if (item.CompareTo(comparator) > 0)
                {
                    count++;
                }
            }

            return count;
        }
        public override string ToString()
        {
            var result = $"{this.Value.GetType()}: {this.Value}";

            return result;
        }
    }
}
