using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    // 1. Create a class. In that class, create a void method that outputs an integer.
    // Have the method divide the data passed to it by 2.
    public class DoMath
    {
        public void Half(int number, out int result)
        {
            result = number / 2;
        }

        // 4. Create a method with output parameters.
        public static void Version(out int versionMain, out int versionIteration)
        {
            versionMain = 1;
            versionIteration = 14;
        }

        // 5. Overload a method.
        public static void Version(out string versionMain, out string versionIteration)
        {
            versionMain = "1";
            versionIteration = "14";
        }

        // 6. Declare a class to be static.
        // See above
    }
}
