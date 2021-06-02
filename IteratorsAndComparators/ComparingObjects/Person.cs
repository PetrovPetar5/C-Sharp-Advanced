using System;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Town = town;
            Age = age;
        }

        public string Name { get; private set; }
        public string Town { get; private set; }
        public int Age { get; private set; }
        public int CompareTo(Person other)
        {
            var result = 1;

            if (other != null)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    this.Age.CompareTo(other.Age);
                    if (result == 0)
                    {
                        this.Town.CompareTo(other.Town);
                    }
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            if (!(obj == null) && obj is Person)
            {
                return this.CompareTo(obj as Person) == 0;
            }

            return false;
        }
    }
}

