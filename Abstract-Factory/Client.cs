using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Client
    {
        ICar car;
        IMotorcycle motorcycle;

        public Client(IVehicle factory)
        {
            car = factory.GetCar();
            motorcycle = factory.GetMotorcycle();
        }

        public string GetCarModelDetails()
        {
            return car.GetDetails();
        }

        public string GetMotorcycleModelDetails()
        {
            return motorcycle.GetDetails();
        }
    }
}
