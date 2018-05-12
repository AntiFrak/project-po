using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Airport : Company
    {
        private string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        private double CoordX
        {
            get { return CoordX; }
            set { CoordX = value; }
        }
        private double CoordY
        {
            get { return CoordY; }
            set { CoordY = value; }
        }

        public Airport(string name, double coordX, double coordY)
        {
            Name = name;
            CoordX = coordX;
            CoordY = coordY;
        }
    }
}
