using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    abstract class Airplane
    {
        protected string Name
        {
            get;
            set;
        }
        protected int Id
        {
            get;
            set;
        }
        protected int Capacity
        {
            get;
            set;
        }

        protected double MaxDistans
        {
            get;
            set;
        }
    }
}
