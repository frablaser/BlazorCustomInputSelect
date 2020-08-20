using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomSelect.Data
{
    public class Persons
    {
        public string PersonsName { get; set; }
        public DateTime? PersonsBirthDate { get; set; }

        /// <summary>
        /// Gender 1-Man 2-Woman 3-Couple
        /// </summary>
        public int Gender { get; set; }

        public List<Person> Related { get; set; }

    }

    public class Person
    {
        public int PersGender { get; set; }
        public string PersName { get; set; }

        public int PersAge { get; set; }

    }

}
