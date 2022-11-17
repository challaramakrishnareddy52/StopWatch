﻿using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hi");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed :{0}", stopwatch.Elapsed);
        }
    }
}