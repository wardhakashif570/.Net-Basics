using System;


class Program
{
    public static void Main(string[] args)
    {
        int sum = 0, m;
        Console.WriteLine("Enter a number to calculate the sum of digits");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number > 0)
        {
            m = number % 10;
            sum = sum + m;
            number = number / 10;
        }
        Console.WriteLine("The sum of a number is " + sum);
    }
}