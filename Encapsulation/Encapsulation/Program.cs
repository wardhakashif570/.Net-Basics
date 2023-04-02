public class EncapsulationData
{
    private int accountNo = 10000;

    /*public void SetData(int account)
    {
        accountNo = account;
    }
    public int GetAccountNo() { return accountNo; }*/

    public int Balance
    {
        set
        {
            accountNo = value;
        }
        get
        {
            return accountNo;
        }
    }
}
    
    public class Program
    {
        public static void Main(string[] args)
        {
            EncapsulationData obj1 = new EncapsulationData();
            obj1.Balance = 1000;
            Console.WriteLine("Account Number is " + obj1.Balance);
            Console.ReadLine();

        }
    }
