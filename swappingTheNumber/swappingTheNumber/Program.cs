class Program
{
    public static void Main(string[] args)
    {
        //Swapping the two numbers
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int tempvar;
        tempvar = number1;
        number1 = number2;
        number2 = tempvar;

        Console.WriteLine("number1 " + number1);
        Console.WriteLine("number2 " + number2);
    }
}