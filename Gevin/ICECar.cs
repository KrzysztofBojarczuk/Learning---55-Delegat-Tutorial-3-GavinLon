using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevin
{
    public class ICECar : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Internal Combustion Engine";
        }
    }
}
