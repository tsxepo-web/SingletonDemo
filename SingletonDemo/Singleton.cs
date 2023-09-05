using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                return NestedSingleton.instance;
            }
        }
        private class NestedSingleton
        {
            static NestedSingleton() { }
            internal static readonly Singleton instance = new();
        }
    }
}
