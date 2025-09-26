using System;
namespace Assignment
{
    class Class3
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
                Console.ReadKey();
            }
        }
    }
}
