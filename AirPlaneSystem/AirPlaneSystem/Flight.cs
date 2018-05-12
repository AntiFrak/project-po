using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Flight : Company
    {
        private Airport From 
        {
            get;
            set;
        }
        private Airport To 
        {
            get;
            set;
        }
        public double GetDistans()
        {
            return Math.Sqrt(Math.Pow(From - toX, 2) + Math.Pow(fromY - toY, 2));
        }

        public Flight(Airport from, Airport to)
        {
            From = from;
            To = to;
            GetDistans();
        }
    }
}
