// a string is an object stored as char
// string objects are immutable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is an example of s1 ...";
            s1 = s1 + "this is s1 but it is added to by creating a new string not really appending.";
            Console.WriteLine(s1);

            StringBuilder sb2 = new StringBuilder("This is an example of");
            sb2.Append(" string concatenation with string builder object");
            Console.WriteLine(sb2);

            sb2.AppendLine();
            sb2.Append(" using StringBuilder...");
            Console.WriteLine(sb2);

            sb2.Replace("StringBuilder", "the stringbuilder class...");
            Console.WriteLine(sb2);
        }
    }
}