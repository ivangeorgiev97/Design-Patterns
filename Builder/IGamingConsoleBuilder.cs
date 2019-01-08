using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IGamingConsoleBuilder
    {
        double Price { get; set; }
        bool IsLimited { get; set; }

        GamingConsole GetFinalResult();
    }
}
