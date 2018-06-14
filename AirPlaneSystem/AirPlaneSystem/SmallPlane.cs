using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    public class SmallPlane : Airplane
    {
        public SmallPlane(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.MaxDistans = 400d;
            this.Capacity = 50;
        }
    }
}
