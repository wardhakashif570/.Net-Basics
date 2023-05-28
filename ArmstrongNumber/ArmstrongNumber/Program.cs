using System;
using System.Diagnostics;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check whether it is Armstrong or not");
        int userInput = int.Parse(Console.ReadLine());
        int temp = userInput;
        int r, sum = 0;
        while (userInput > 0)
        {

            r = userInput % 10;
            sum = sum + (r * r * r);
            userInput = userInput / 10;

        }
        if (temp == sum)
        {
            Console.WriteLine("It is an Armstrong number");
        }
        else
        {
            Console.WriteLine("it is not an Armstrong number");
        }

    }
}
