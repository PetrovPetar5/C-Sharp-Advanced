namespace IteratorsAndComparators
{
    using System.Collections.Generic;
    using System.Linq;

    public class Book
    {
        private readonly ICollection<string> authors;
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            this.Year = year;
            this.authors = authors;
        }

        public string Title { get; }
        public int Year { get; }
        public IReadOnlyCollection<string> Authors => this.authors.ToList().AsReadOnly();
    }
}
