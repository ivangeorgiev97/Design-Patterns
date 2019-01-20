using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton onlyInstance; 

        // Конструкторът може да бъде и protected
        private Singleton() { }

        public static Singleton OnlyInstance
        {
            get
            {
                if (onlyInstance == null)
                {
                    onlyInstance = new Singleton();
                }

                return onlyInstance;
            }
        }
    }
}
