using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class GamingConsoleBuildDirector
    {
        private IGamingConsoleBuilder builder;

        public GamingConsoleBuildDirector(IGamingConsoleBuilder gamingConsoleBuilder)
        {
            builder = gamingConsoleBuilder;
        }

        public void Construct()
        {
            builder.Price = 400;
            builder.IsLimited = true;
        }
    }
}
