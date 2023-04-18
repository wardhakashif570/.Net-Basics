using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentdetails(),
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            /*
             * Assuming Singleton is created from employee class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentdetails()
        {
            /*
                         * Assuming Singleton is created from student class
                         * we refer to the GetInstance property from the Singleton class
                         */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
