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
            Thread t0 = new Thread(WriteX);

        
            
            Thread t2 = new Thread(Writek);

            //Thread t3 = new Thread( () => Console.WriteLine("hi"));

            //t3.Start();
            t2.Start();
            t0.Start();
            // for (int i = 0; i < 1000; i++)
            // {
            //     Console.Write(".");
            // }
        }

        static void WriteX() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");             
            }
        }
        
        static void Writek()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("k");
            }
        }

    }
}