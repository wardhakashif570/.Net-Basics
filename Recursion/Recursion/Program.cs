// See https://aka.ms/new-console-template for more information

public class Recursion
{
    int number = 5;
    int result = 1;
    public int Fact()
    {
        if (number == 0)
        {
            return 1;
        }

        result = number * result;
        number--;
        Fact();

        return result;

    }

}
class Program
{
    public static void Main(String[] args)
    {
        Recursion obj1 = new Recursion();
       Console.WriteLine(obj1.Fact());
    }
}
