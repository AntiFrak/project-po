using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    public class Airport
    {
        private double coordX, coordY;
        public string Name
        {
            get;
            set;
        }
        public double CoordX
        {
            get { return coordX; }
            set
            {
                if (CoordX < -500 || CoordX > 500)
                    Console.WriteLine("Invalid coordination!!!");
                else coordX = value;
            }
        }
        public double CoordY
        {
            get { return coordY; }
            set
            {
                if (CoordY < -500 || CoordY > 500)
                    Console.WriteLine("Invalid coordination!!!");
                else coordY = value;
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
