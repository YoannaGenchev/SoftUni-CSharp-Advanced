﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            int result = name.CompareTo(other.name);
            if (result == 0)
            {
                result = age.CompareTo(other.age);
                if (result == 0)
                {
                    result = town.CompareTo(other.town);
                }
            }
            
            return result;
        }
    }
}
