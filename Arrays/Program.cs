using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 4: Arrays
            Console.WriteLine("\n\nArray operations:");
            int[] numbers = new int[5] { 5, 8, 12, 3, 6 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            Console.ReadKey();
        }
    }
}
