using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            var result = first.Title.CompareTo(second.Title);
            if (result == 0)
            {
                result = first.Year.CompareTo(second.Year) * -1;
            }

            return result;
        }
    }
}
