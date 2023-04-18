using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass instance = null;

        public static SingletonClass GetInstance
        {
            get
            {
                if (instance == null)

                    instance = new SingletonClass();

                return instance;
            }

        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
