using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = books.ToList();
        }

        public List<Book> Books { get; set; }
        public IEnumerator<Book> GetEnumerator()
        {
            Books.Sort(new BookComparator());
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;

            public LibraryIterator(List<Book> books)
            {
                this.Books = books;
            }

            public List<Book> Books { get; set; }
            public object Current => this.Books[this.index];

            Book IEnumerator<Book>.Current => this.Books[this.index];

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++this.index < this.Books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}
