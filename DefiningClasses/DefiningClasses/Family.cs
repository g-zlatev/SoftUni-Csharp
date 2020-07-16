using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> peopleList;

        public Family()
        {
            this.peopleList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.peopleList.Add(member);
        }

        public Person GetOldestMember()
        {
            Person person = new Person();

            person = this.peopleList.OrderByDescending(x => x.Age).FirstOrDefault();

            return person;

        }

        
    }
}
