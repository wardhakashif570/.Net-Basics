using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to Find Factorial");
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine( "The factorial of a number is " + fact);
    }
}