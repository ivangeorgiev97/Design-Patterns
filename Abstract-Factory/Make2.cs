using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Make2 : IVehicle
    {
        public ICar GetCar()
        {
            return new Make2CarModel1();
        }

        public IMotorcycle GetMotorcycle()
        {
            return new Make2MotorcycleModel1();
        }
    }
}
