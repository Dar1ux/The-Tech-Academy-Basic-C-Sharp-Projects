using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, create a list of at least 10 employees.
            // At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Rob", "Jones"));
            employees.Add(new Employee(2, "Joe", "Biden"));
            employees.Add(new Employee(3, "Felipe", "Moris"));
            employees.Add(new Employee(4, "Elon", "Musk"));
            employees.Add(new Employee(5, "Jesse", "Smith"));
            employees.Add(new Employee(6, "Samantha", "Dockser"));
            employees.Add(new Employee(7, "Jessica", "Miles"));
            employees.Add(new Employee(8, "Joe", "Malik"));
            employees.Add(new Employee(9, "Lisa", "Manoban"));
            employees.Add(new Employee(10, "Rose", "McKenzie"));

            // 3. Using a foreach loop, create a new list of all employees with the first name “Joe”.
            // In your comparison statement, remember to reference the property of the object you are checking.
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            Console.WriteLine("Joe list created with foreach loop:");
            foreach (Employee emp in joeList)
            {
                Console.WriteLine(emp.FirstName);
            }

            // 4. Perform the same action again, but this time with a lambda expression.
            List<Employee> joeList2 = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\nJoe list created with lambda expression:");
            foreach (Employee emp in joeList2)
            {
                Console.WriteLine(emp.FirstName);
            }

            // 5. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> bigId = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\nID's greater than 5:");
            foreach (Employee emp in bigId)
            {
                Console.WriteLine("{0} {1} {2}", emp.Id, emp.FirstName, emp.LastName);
            }

            Console.ReadLine();
        }
    }
}
