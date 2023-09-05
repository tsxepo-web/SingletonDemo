using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();
        static Singleton() { }
        private Singleton() { }

        public static Singleton getInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
