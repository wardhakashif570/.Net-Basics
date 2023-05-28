using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an string to check whether the string is Palindrome or not");
        string input = Console.ReadLine();


        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is Palindrome");
        }
        else
        {
            Console.WriteLine("The string is not a Palindrome");
        }

    }
    static bool IsPalindrome(string input)
    {
        input = input.ToLower();
        int left = 0;
        int right = input.Length - 1;

        if (left < right)
        {
            while (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
