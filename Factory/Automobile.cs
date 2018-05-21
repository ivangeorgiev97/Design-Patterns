using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Automobile : IVehicle
    {
        private string make;
        private string model;

        public Automobile(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public string GetMakeAndModel()
        {
            return this.make + "->" + this.model;
        }
    }
}
