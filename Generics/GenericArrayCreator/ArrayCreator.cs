using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int Length, T item)
        {
            var customArr = new T[Length];
            for (int i = 0; i < customArr.Length; i++)
            {
                customArr[i] = item;
            }

            return customArr;
        }
    }
}
