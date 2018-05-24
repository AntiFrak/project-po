using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    abstract class Airplane
    {
        public string Name
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public int Capacity
        {
            get;
            set;
        }

        public double MaxDistans
        {
            get;
            set;
        }
    }
}
