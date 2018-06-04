using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make1
            IVehicle make1 = new Make1();
            Client make1Client = new Client(make1);

            // Details for Make1
            Console.WriteLine("Make 1:");
            Console.WriteLine(make1Client.GetCarModelDetails());
            Console.WriteLine(make1Client.GetMotorcycleModelDetails());

            // Make2
            IVehicle make2 = new Make2();
            Client make2Client = new Client(make2);

            // Details for Make1
            Console.WriteLine("Make 2:");
            Console.WriteLine(make2Client.GetCarModelDetails());
            Console.WriteLine(make2Client.GetMotorcycleModelDetails());
        }
    }
}
