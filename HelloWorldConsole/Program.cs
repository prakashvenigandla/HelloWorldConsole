using System;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
