

namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class BookEnumerator : IEnumerator<Book>
    {
        private int currentIndex = -1;
        private Book[] books;
        public BookEnumerator(Book[] books)
        {
            this.Reset();
            this.books = books;
        }
        public Book Current => this.books[this.currentIndex];

        public int Count => throw new NotImplementedException();

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            this.currentIndex++;

            if (this.books.Length <= currentIndex)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }
    }
}
