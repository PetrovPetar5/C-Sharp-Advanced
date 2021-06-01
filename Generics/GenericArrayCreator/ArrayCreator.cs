namespace GenericArrayCreator
{
    public static class ArrayCreator<T>
    {
        public static T[] Create(int length, T item)
        {
            var collection = new T[length];

            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = item;
            }

            return collection;
        }
    }
}
