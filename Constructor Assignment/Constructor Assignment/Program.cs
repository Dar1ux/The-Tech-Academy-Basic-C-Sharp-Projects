using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor Assignment
            // Perform these actions and create a console app that includes the following:
            // 1. Create a const variable.
            const string copyright = "©1DarLab";

            // 2. Create a variable using the keyword “var.”
            var user = "Jesse";

        }
        
    }
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        // 3. Chain two constructors together.
        public User(string userName) : this(userName, "example@email.com")
        {

        }
        public User(string userName, string email)
        {
            this.UserName = userName;
            this.Email = email;
        }
    }
}
