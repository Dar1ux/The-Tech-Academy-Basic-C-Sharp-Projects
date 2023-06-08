using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Inside the Main() method, instantiate an Employee object with firstName “Sample”
            // and lastName “Student”. Call the SayName() method on the object.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();

            // Polymorphism Assignment Submission
            // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            // Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable gamer = new Employee() { firstName = "Elon", lastName = "Musk"};
            gamer.Quit();

            Console.ReadLine();
        }
    }
}
