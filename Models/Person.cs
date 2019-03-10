using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDb.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => $"{FirstName} {LastName}"; 
        public IList<int> YearsActive { get; set; }
    }

    public class Director : Person
    {

    }

    public class Actor : Person
    {

    }
}
