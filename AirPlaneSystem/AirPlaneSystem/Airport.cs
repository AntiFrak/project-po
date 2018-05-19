using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Airport
    {
        public string Name
        {
            get;
            set;
        }
        public double CoordX
        {
            get { return CoordX; }
            set
            {
                if (CoordX < -500 || CoordX > 500)
                    Console.WriteLine("Invalid coordination!!!");
                else CoordX = value;
            }
        }
        public double CoordY
        {
            get { return CoordY; }
            set
            {
                if (CoordY < -500 || CoordY > 500)
                    Console.WriteLine("Invalid coordination!!!");
                else CoordY = value;
            }
        }

        public Airport(string name, double coordX, double coordY)
        {
            Name = name;
            CoordX = coordX;
            CoordY = coordY;
        }
    }
}
