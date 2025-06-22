using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton Logger:\n");

            Logger logger1 = Logger.GetInstance();
            logger1.Log("First log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second log message.");

            if (logger1 == logger2)
                Console.WriteLine("\nlogger1 and logger2 are the same instance. Singleton works!");
            else
                Console.WriteLine("\nDifferent instances found. Singleton failed.");
        }
    }
}
