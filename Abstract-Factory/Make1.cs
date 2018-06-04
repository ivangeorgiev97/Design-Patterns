using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Make1 : IVehicle
    {
        public ICar GetCar()
        {
            return new Make1CarModel1();
        }

        public IMotorcycle GetMotorcycle()
        {
            return new Make1MotorcycleModel1();
        }
    }
}
