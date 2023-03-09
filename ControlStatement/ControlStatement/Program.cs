// See https://aka.ms/new-console-template for more information

int number = 10;
if (number == 10)
{
    Console.WriteLine("The Number is 10");
    Console.ReadLine();
}
else if (number == 11)
{
    Console.WriteLine("The Number is 11");
    Console.ReadLine();
}
else
{
    Console.WriteLine("The Number is not 10 nor 11");
    Console.ReadLine();

}

// using the switch statement

switch (number)
{
    case 10:
        Console.WriteLine("The Number is 10");
        break;
    case 11:
        Console.WriteLine("The Number is 11");
        break;
      default:
        Console.WriteLine("The Number is not 10 nor 11");
        break;
 
}

