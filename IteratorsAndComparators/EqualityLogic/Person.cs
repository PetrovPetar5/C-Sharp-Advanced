using System;
using System.Diagnostics.CodeAnalysis;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 1 || value.Length > 50 )
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException();
                }

                this.age = value;
            }
        }

        public int CompareTo([AllowNull] Person other)
        {
            var result = 1;
            if (other != null)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Age.CompareTo(other.Age);
                }
            }

            return result;
        }
    }
}
