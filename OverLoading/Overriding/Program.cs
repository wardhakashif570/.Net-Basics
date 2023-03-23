using System.Diagnostics.Contracts;

class Calculation
{
    public void CalculateData(int num1,int num2)
    {
        Console.WriteLine("The sum of two numbers is " +  (num1 + num2));
    }
    public void CalculateData(float num1, float num2)
    {
        Console.WriteLine("The sum of two numbers is " + (num1 + num2));
    }

    public static void Main(string[] args)
    {
        Calculation calc = new Calculation();
        calc.CalculateData(10, 20);
    }


}