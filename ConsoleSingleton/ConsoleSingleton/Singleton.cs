using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSingleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
