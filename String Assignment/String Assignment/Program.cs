using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "Hello my friend. ";
            string sentence2 = "I have great news. ";
            string sentence3 = "I just won 1,000,000 dollars!!! ";
            // 1. Concatenates three strings.
            string paragraph = sentence1 + sentence2 + sentence3;
            Console.WriteLine(paragraph);

            // 2. Converts a string to uppercase.
            Console.WriteLine(sentence3.ToUpper());

            // 3. Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append(sentence1);
            Console.WriteLine(sb);
            sb.Append(sentence2);
            Console.WriteLine(sb);
            sb.Append(sentence3);
            Console.WriteLine(sb);

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
