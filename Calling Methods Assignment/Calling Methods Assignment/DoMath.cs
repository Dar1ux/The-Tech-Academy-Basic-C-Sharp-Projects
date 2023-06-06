using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class DoMath
    {
        public static int Square (int num1) // Defining a method with its Access Modifier, a Return Type, and Parameter
        {
            int square = num1 * num1;
            return square;
        }

        public static int AddItself(int num1)
        {
            int addItself = num1 + num1;
            return addItself;
        }

        public static int Negative(int num1)
        {
            int negative = num1 * -1;
            return negative;
        }
    }
}
