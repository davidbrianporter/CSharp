using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark m = new Mark();
            m.AddNumbers(3, 3);
            m.MultiplyNumbers(3, 3);
            m.SubtractNumbers(3, 4);
        }
    }

    public class Mark
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("AddNumbers: a+b= " + (a + b));
        }
        public void  MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("MultiplyNumbers: a*b= " + (a * b));
        }
        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine("SubtractNumbers: a-b= " + (a - b));
        }
    }
}
