using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVehicle
    {
        public void Driving();

        public bool Refuel(int liters);
    }
}
