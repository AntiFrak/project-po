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

        public void AddAirplane(string name, int id)
        {
            //Airplanes.Add(new BigPlane(name, id));
            //Airplanes.Add(new MediumPlane(name, id));
            //Airplanes.Add(new SmallPlane(name, id));
        }
        public void RemoveAirplane(int i)
        {
            airplanes.RemoveAt(i);
        }
        public Airplane GetAirplane(int i)
        {
            return airplanes[i];
        }
        public List<Airplane> GetAllAirplanes()
        {
            return airplanes;
        }

        public void AddClient(string name, string surname, string pesel)
        {
            //Clients.Add(new PrivatePerson(name, surname, pesel));
            //Clients.Add(new FlightAgent(name, idNumber));
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

        public void AddFlight(int i, int y, Airport from, Airport to)
        {
            flights.Add(new Flight(from = airports[i], to.airports[y].));
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
