namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public class Book : IComparable<Book>
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

        public int CompareTo( Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }

            return result;
        }

        public override string ToString()
        {
            var result = $"{this.Title} - {this.Year}";

            return result;
        }
    }
}
