using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //SI = P*T*R/100

            Console.WriteLine("Enter the value of principal (p): ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter time in years (T): ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest (R): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            int SimpleInterest = (int)(principal * time * rate) / 100;

            Console.WriteLine($"Simple Interest = {SimpleInterest}");
            Console.Read();
        }
    }
}
