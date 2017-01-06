using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark m = new Mark();
            m.AddNumbers(3, 3);
            m.MultiplyNumbers(4, 4);
            Console.WriteLine("hi");
        }
    }



    public class Mark 
    {
        public int AddNumbers(int a, int b) 
        {
            return a + b;
        }

        public int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}

