using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class FlightAgent : Client
    {
        private string Name
        {
            get;
        }
        private string IdNumber
        {
            get;
        }
        public FlightAgent(string name, string idNumber)
        {
            Name = name;
            IdNumber = idNumber;
        }
    }
}
