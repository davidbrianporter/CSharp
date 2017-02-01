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
        // the Main thread
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteX);
            t.Start();
            Thread t2 = new Thread(Writek);
            t2.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(".");
            }
        }

        static void WriteX() 
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("x");             
            }
        }
        
        static void Writek()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("k");
            }
        }

    }
}