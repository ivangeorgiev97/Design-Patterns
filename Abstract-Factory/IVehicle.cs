using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface IVehicle
    {
        ICar GetCar();
        IMotorcycle GetMotorcycle();
    }
}
