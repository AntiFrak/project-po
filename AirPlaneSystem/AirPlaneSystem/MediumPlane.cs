using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class MediumPlane : Airplane
    {
        public MediumPlane(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.MaxDistans = 750d;
            this.Capacity = 150;
        }
    }
}
