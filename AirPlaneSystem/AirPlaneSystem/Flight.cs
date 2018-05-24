using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Flight
    {
        public DateTime Date
        {
            get;
        }
        public DateTime ArrivalDate
        {
            get;
        }
        public Airport From 
        {
            get;
        }
        public Airport To 
        {
            get;
        }
        public Airplane Ap
        {
            get;
        }
        public double Distans
        {
            get;
        }

        public Flight(Airport from, Airport to, Airplane ap, DateTime date)
        {
            From = from;
            To = to;
            Ap = ap;
            Date = date;
            Distans = Math.Sqrt(Math.Pow(From.CoordX - To.CoordX, 2) + Math.Pow(From.CoordY - To.CoordY, 2));
            ArrivalDate = Date.AddHours(Distans / 25); //sped= 25 m/h
        }
    }
}
