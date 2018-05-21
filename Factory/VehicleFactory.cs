using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    static class VehicleFactory
    {
        public static IVehicle Create(string make, string model)//,num)
        {
          //  if (num == 1)
           //{
                return new Automobile(make, model);
            //} 
            //else
            //{
                // create something else...
           // }
        }
    }
}
