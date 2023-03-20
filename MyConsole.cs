using System;
using System.Threading;

namespace Project_CS
{
    public class PrintSlow
    {
        public void PrintSlowly(string print)
        {
            foreach (char l in print)
            {
                Console.Write(l);
                Thread.Sleep(2); // sleep for 10 milliseconds
            }
            Console.Write("\n");
        }
    }
}