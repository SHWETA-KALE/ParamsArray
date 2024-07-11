using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of using a method with params array
            DisplayNumbers(1, 2, 3, 4, 5);

            // Example to demonstrate if WriteLine() uses params array internally
            Console.WriteLine("Example of WriteLine() with params: {0}, {1}, {2}", 10, 20, 30);
        }

        static void DisplayNumbers(params int[] numbers)
        {
            Console.WriteLine("Numbers passed to DisplayNumbers method:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
