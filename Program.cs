using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        // args is the name of the parameter
        {   
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello no name!");
            }
        }
    }
}
