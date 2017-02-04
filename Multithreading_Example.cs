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
            Thread tx = new Thread(WriteX);

            Thread tdot = new Thread(WriteDot);        
            
            Thread tdash = new Thread(WriteDash);

            //Thread t3 = new Thread( () => Console.WriteLine("hi"));

            //t3.Start();
            tx.Start();
            tdot.Start();
            if (tx.IsAlive)
            {
                tdash.Start();
            }

        }

        static void WriteX() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");             
            }
        }
        
        static void WriteDot()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }
        }

        static void WriteDash()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("-");
            }
        }

    }
}