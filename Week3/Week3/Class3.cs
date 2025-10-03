using System;

class Class3
{
    static void Main()
    {
        int number = 0; 

        while (number != -1)
        {
            Console.Write("Enter a number (-1 to exit): ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number != -1)
            {
                Console.WriteLine("You entered: " + number);
            }
        }

        Console.WriteLine("Program exited.");
    }
}
