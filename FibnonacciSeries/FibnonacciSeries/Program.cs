class Program
{
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 1, n3, num;

        Console.WriteLine("Enter number of elements ");
        num = int.Parse(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " ");
        for (int i = 2; i <= num; i++)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;

            Console.Write(n3 + " ");

        }


    }
}