using System;
using System.Collections;

namespace Demo
{
    class Programs
    {
        static void Main(string[] args)
        {
            Queue ar = new Queue();

            ar.Enqueue(1);
            ar.Enqueue(2);
            ar.Enqueue(3);

            Console.WriteLine("There are " + ar.Count + " elememts in the queue.");
            Console.Read();
        }
    }
}