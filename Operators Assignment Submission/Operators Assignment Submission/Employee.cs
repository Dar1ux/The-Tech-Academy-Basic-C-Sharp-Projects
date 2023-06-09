﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    // 1. Create an Employee class with Id, FirstName and LastName properties.
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. In the Employee class, overload the “==” operator so it checks if two Employee
        // objects are equal by comparing their Id property.
        // Remember that comparison operators must be overloaded in pairs. 
        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Overloading operator != as a pair to ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
