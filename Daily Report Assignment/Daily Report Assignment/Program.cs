using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string tempPage = Console.ReadLine();
            short yourPage = Convert.ToInt16(tempPage);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string tempHelp = Console.ReadLine();
            bool yourHelp = Convert.ToBoolean(tempHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string tempHours = Console.ReadLine();
            short yourHours = Convert.ToInt16(tempHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
