
namespace Singleton
{
    class Program
    {
        //sealed class restrict the Inheritance
        static void Main(string[] args)
        {
            SingletonClass S1 = SingletonClass.GetInstance;
            S1.PrintDetails("This is S1 Class");


            SingletonClass S2 = SingletonClass.GetInstance;
            S2.PrintDetails("This is S2 Class");
        }

    }
}
