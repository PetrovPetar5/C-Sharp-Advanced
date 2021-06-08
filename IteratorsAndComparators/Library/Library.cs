namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Library : IEnumerable<Book>
    {
        private readonly Book[] books;

        public Library(params Book[] books)
        {
            this.books = books;
            Array.Sort(this.books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {

            return new BookEnumerator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
