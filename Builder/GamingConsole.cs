using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class GamingConsole
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public bool IsLimited { get; set; }

        public GamingConsole(string make, string model, double price, bool isLimited)
        {
            Make = make;
            Model = model;
            Price = price;
            IsLimited = isLimited;
        }
    }
}
