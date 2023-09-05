using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object instanceLock = new();
        private Singleton()
        {

        }

        public static Singleton getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        { instance = new Singleton(); }
                    }
                }
                return instance;
            }
        }
    }
}
