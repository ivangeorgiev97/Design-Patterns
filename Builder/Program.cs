using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder1 = new Make1Builder();
            GamingConsoleBuildDirector director1 = new GamingConsoleBuildDirector(builder1);

            director1.Construct();

            GamingConsole testGamingConsole1 = builder1.GetFinalResult();

            // Console.WriteLine(builder1.GetType().Name);
            Console.WriteLine(builder1.IsLimited);
        }
    }
}
