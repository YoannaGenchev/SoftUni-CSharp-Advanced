using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + age.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person other)
            {
                return this.name == other.name && this.age == other.age;
            }

            return false;
        }

        public int CompareTo(Person? other)
        {
            int result = name.CompareTo(other.name);
            if (result == 0)
            {
                return age.CompareTo(other.age);
            }

            return result;
        }
    }
}
