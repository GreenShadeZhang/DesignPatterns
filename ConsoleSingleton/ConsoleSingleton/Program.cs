using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSingleton
{
    class Program
    {

      static  Singleton singleton1 = null;
        static Singleton singleton2 = null;
        private static void Create()
        {
            singleton1 = Singleton.GetInstance();
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Create));
            thread.Start();
            Thread thread2 = new Thread(new ThreadStart(Create2));
            thread2.Start();
            //Singleton singleton1 = Singleton.GetInstance();
            //Singleton singleton2 = Singleton.GetInstance();
            if (singleton1 == singleton2)
            {
                Console.WriteLine("相同");
            }
            Console.ReadKey();
        }

        private static void Create2()
        {
            singleton2 = Singleton.GetInstance();
        }
    }
}
