class Program
{
    public static void Main(string[] args)
    {
        List<string> cars = new List<string>();
        cars.Add("BMW");
        cars.Add("Corolla");
        cars.Add("Civic");

        foreach(string car in cars)
        {
            Console.WriteLine(car);
        }

    }
}
