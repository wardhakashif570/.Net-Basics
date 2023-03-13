// See https://aka.ms/new-console-template for more information
using ClassesandObject;

namespace ClassesandObject
{
    public class Class1
    {
        int number1 = 10;
        int number2 = 20;

        public  void Add(int number1, int number2)
        {
            Console.WriteLine("The sum of the number is "+ (number1 + number2));
        }

    }

  
}
public class Program
{
    public static void Main(string[] args)
    {
        Class1 obj1 = new Class1();
        
        obj1.Add(2, 4);
    }
}
