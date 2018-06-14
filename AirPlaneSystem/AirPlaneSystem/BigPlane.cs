using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
     public class BigPlane : Airplane
    {
        public BigPlane(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.MaxDistans = 1500d;
            this.Capacity = 300;
        }
    }
}
