using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class DoMath
    {
        // 1. Create a class. In that class, create a method that takes two integers as parameters.
        // Make one of them optional. Have the method do a math operation and return an integer result.
        public int Quote(int price, int units = 1)
        {
            int shipping = 5;
            int total = (price + shipping) * units;
            return total;
        }
    }
}
