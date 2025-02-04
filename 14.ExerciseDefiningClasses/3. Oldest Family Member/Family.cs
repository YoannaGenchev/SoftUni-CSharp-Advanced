using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public List<Person> Members 
        { 
            get { return this.members; }
            set { this.members = value; }
        }

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(person => person.Age).First();
        }
    }
}