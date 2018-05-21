using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton myInstance; 

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (myInstance == null)
                {
                    myInstance = new Singleton();
                }

                return myInstance;
            }
        }
    }
}
