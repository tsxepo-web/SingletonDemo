using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazyObj = new Lazy<Singleton>(() => new Singleton());
        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                return lazyObj.Value;
            }
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Displaying message");
        }
    }
}
