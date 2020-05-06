using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }

    public class PersonList : List<Person>
    {
        public string Heading { get; set; }
        public List<Person> Persons => this;
    }


}
