using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        public EqualityScale(T firstElement, T secondElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
        }
        public T FirstElement { get; set; }
        public T SecondElement { get; set; }

        public bool AreEqual()
        {
            return this.FirstElement.Equals(this.SecondElement);
        }
    }
}
