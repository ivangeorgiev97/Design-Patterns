using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Make1MotorcycleModel1 : IMotorcycle
    {
        public string GetDetails()
        {
            return "Model: RandomMotorcycleModel1\nColor: blue";
        }
    }
}
