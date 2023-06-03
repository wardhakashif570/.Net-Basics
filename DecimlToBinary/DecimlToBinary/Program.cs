class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Decimal To Binary");
        int DecimaNumber=Convert.ToInt32(Console.ReadLine());
        string binaryNumber = Convert.ToString(DecimaNumber, 2);
        Console.WriteLine(binaryNumber);
    }
}