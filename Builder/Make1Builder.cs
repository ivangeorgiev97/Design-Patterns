using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Make1Builder : IGamingConsoleBuilder
    {
        public double Price { get; set; }
        public bool IsLimited { get; set; }

        public GamingConsole GetFinalResult()
        {
            return Price == 400 ? new GamingConsole("Make1", "Model1", Price, IsLimited) : null;
        }
    }
}
