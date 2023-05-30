class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to reverse");
        int input = Convert.ToInt32(Console.ReadLine());
        int reverse = 0, temp;

        while (input != 0)
        {
            temp = input % 10;
            reverse = reverse * 10 + temp;
            input = input / 10;
        }

        Console.WriteLine("The reverse of a number is " + reverse); 
    }
}