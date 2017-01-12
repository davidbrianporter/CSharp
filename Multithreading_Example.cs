using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteX);
            t.Start();

            for (int i = 0; i < 100000; i++)
            {
                Console.Write(".");
            }
        }

        static void WriteX() 
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.Write("x");             
            }
        }
    }
}