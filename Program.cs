using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        // args is the name of the parameter
        {   
            var numbers = new [] {12.7, 10.3, 6.11};
            

            // var result = numbers[0];
            // result = result + numbers[1];
            // result = result + numbers[2];
            // Loop

            var result=0.0;
            foreach (var item in numbers)
            {
                result+= item;
            }
            Console.WriteLine(result);


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

/* Here is a given problem
We need an electronic grade book to read the scores of an individual student and then compute some simple
statistics from the scores

The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade,
the lowest grade, and the average grade.
*/

