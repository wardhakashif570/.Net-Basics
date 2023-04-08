using System;
public class Program
{

    static void Main(string[] args)

    {
        string[] cars = new string[4] { "BMW", "Corolla", "City", "Civic" };

        {

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

}