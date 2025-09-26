using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Swap without a third variable
            a = a + b;   // sum of a and b
            b = a - b;   // now b = original a
            a = a - b;   // now a = original b

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}
