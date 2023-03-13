// See https://aka.ms/new-console-template for more information
public class Calculator
{
    int number1 = 10;
    int number2 = 20;
    int result;
    public void Add()
    {
        result = number1 + number2;
        ShowResult();
    }
    public void Subtract()
    {
        result = number1 - number2;
        ShowResult();
    }
    public void Multiplication()
    {
        result = number1 * number2;
        ShowResult();
    }
    public void  Devision()
    {
        result = number1 / number2;
        ShowResult();
    }
    public void ShowResult()
    {
        Console.WriteLine(result);
    }

    public static void Main(string[] args)
    {
        Calculator obj = new Calculator();
        obj.Subtract();

    }
}