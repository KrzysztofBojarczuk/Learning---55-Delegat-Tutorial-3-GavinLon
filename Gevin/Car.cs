using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevin
{
    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetCarDetails()
        {
            return $"{Id} - {Name} ";
        }
    }
}
