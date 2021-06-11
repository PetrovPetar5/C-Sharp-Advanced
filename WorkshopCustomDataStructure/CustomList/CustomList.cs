namespace CustomList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CustomList<T>
    {
        private T[] items;

        public CustomList()
        {
            this.items = new T[2];
        }


    }
}
