public class ConstructorData
{
    string Firstname;
    string Lastname;

    public ConstructorData(string firstname, string lastname)
    {
        Firstname=firstname; Lastname=lastname;

    }
    public static void Main(string[] args)
    {
        ConstructorData obj1 = new ConstructorData("Wardha", "Kashif");
        Console.WriteLine(obj1.Firstname);
        Console.WriteLine(obj1.Lastname);
        Console.ReadLine();
    }
}