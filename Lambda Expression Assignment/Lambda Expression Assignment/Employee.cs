using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    // 1. Create an Employee class with the following properties:
    // a.Id
    // b.First Name
    // c.Last Name
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee (int id, string name, string surname)
        {
            Id = id;
            FirstName = name;
            LastName = surname;
        }
    }
}
