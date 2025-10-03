using System;

class Class1
{
    static void Main()
    {
        Console.Write("Enter a grade (A/B/C): ");
        char grade = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;

            case 'B':
                Console.WriteLine("Good job!");
                break;

            case 'C':
                Console.WriteLine("Needs improvement.");
                break;

            default:
                Console.WriteLine("Invalid grade entered.");
                break;
        }
    }
}
