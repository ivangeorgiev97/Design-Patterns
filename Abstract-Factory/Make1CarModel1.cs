using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Make1CarModel1 : ICar
    {
        public string GetDetails()
        {
            return "Model: RandomCarModel1\nColor: blue";
        }
    }
}
