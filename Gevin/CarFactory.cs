using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevin
{
    public static class CarFactory
    {
        public static ICECar ReturnICECar(int id, string name)
        {
            return new ICECar { Id = id, Name = name };
        }
        public static EVCar ReturnEvCar(int id, string name)
        {
            return new EVCar { Id = id, Name = name };
        }
    }
}
