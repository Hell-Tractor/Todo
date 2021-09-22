using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class Singleton<T> where T : Singleton<T>, new()
    {
        protected static T instance = null;
        private static readonly object locker = new object();
        protected Singleton() { }

        public static T GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
        
    }
}
