﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle automobile = VehicleFactory.Create("MyManufacturer", "MyModel");

            Console.WriteLine(automobile.GetMakeAndModel());
        }
    }
}
