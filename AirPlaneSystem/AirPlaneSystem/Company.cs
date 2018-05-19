using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class Company
    {
        private List<Airplane> airplanes = new List<Airplane>();
        private List<Airport> airports = new List<Airport>(); 
        private List<Flight> flights = new List<Flight>();
        private List<Client> clients = new List<Client>();

        public void AddAirports(string name, double coordX, double coordY)
        {
            Airport a = new Airport(name, coordX, coordY);
            airports.Add(a);
        }
        public void RemoveAirports(int i)
        {
            airports.RemoveAt(i);
        }
        public Airport GetAirport(int i)
        {
            return  airports[i];
        }
        public List<Airport> GetAllAirports()
        {
            return airports;
        }

        public void AddAirplane(string name, int id, int type)
        {
            switch (type) // choise a type of airplane
            {
                case 1:
                    airplanes.Add(new BigPlane(name, id));
                    break;
                case 2:
                    airplanes.Add(new MediumPlane(name, id));
                    break;
                case 3:
                    airplanes.Add(new SmallPlane(name, id));
                    break;
                default:
                    Console.WriteLine("Unknown airplane type!!!");
                    break;
            }

        }
        public void RemoveAirplane(int i)
        {
            airplanes.RemoveAt(i);
        }
        public Airplane GetAirplane(int i)
        {
            return airplanes[i];
        }
        public List<Airplane> GetAllBigAirplanes()
        {
            List<Airplane> bigAirplanes = new List<Airplane>();
            foreach (Airplane a in airplanes)
            {
                if (a is BigPlane)
                    bigAirplanes.Add(a);
            }
            return bigAirplanes;
        }
        public List<Airplane> GetAllMediumAirplanes()
        {
            List<Airplane> mediumAirplanes = new List<Airplane>();
            foreach (Airplane a in airplanes)
            {
                if (a is MediumPlane)
                    mediumAirplanes.Add(a);
            }
            return mediumAirplanes;
        }
        public List<Airplane> GetAllSmallAirplanes()
        {
            List<Airplane> smallAirplanes = new List<Airplane>();
            foreach (Airplane a in airplanes)
            {
                if (a is SmallPlane)
                    smallAirplanes.Add(a);
            }
            return smallAirplanes;
        }
        public List<Airplane> GetAllAirplanes()
        {
            return airplanes;
        }

        public void AddFlightAgent(string name, string idNumber)
        {
            clients.Add(new FlightAgent(name, idNumber));
        }
        public void AddPrivatePerson(string name, string surname, string pesel)
        {
            clients.Add(new PrivatePerson(name, surname, pesel));
        }
        public void RemoveClient(int i)
        {
            clients.RemoveAt(i);
        }
        public Client GetClient(int i)
        {
            return clients[i];
        }
        public List<Client> GetAllClients()
        {
            return clients;
        }

        public void AddFlight(Airport from, Airport to, Airplane ap, DateTime date)
        {
            flights.Add(new Flight(from, to, ap, date));
        }
        public void RemoveFlight(int i)
        {
            flights.RemoveAt(i);
        }
        public Flight GetFlight(int i)
        {
            return flights[i];
        }
        public List<Flight> GetAllFlights()
        {
            return flights;
        }
    }
}
