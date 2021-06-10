namespace EqualityLogic
{
    using System;
    using System.Diagnostics.CodeAnalysis;
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
            get => this.name;
            private set
            {
                if (value.Length == 0 || value.Length > 50)
                {
                    throw new ArgumentException("Name length cannot be less than zero or greater than 50 charachters");
                }

                foreach (var @char in value)
                {
                    if (!Char.IsLetterOrDigit(@char))
                    {
                        throw new ArgumentException("Person’s name should be a string that contains only alphanumerical characters");
                    }
                }

                this.name = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be between 1 and 100");
                }

                this.age = value;
            }
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var otherPerson = obj as Person;
            var areEqual = this.Name == otherPerson.Name && this.Age == otherPerson.Age;

            return areEqual;
        }
    }
}
