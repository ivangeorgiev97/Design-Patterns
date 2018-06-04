using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Make2MotorcycleModel1 : IMotorcycle
    {
        public string GetDetails()
        {
            return "Model: RandomMotorCycleModel2\nColor: grey";
        }
    }
}
