class Animal
{
    public void Eat()
    {
        Console.WriteLine("The Animal eat Food");
    }
}

class Dog:Animal
{
    public void Eat()
    {
        Console.WriteLine("The Dog eat Food");
    }

    public static void Main(string[] args)
    {
        Dog AnimalObj=new Dog();
        AnimalObj.Eat();
    }
}