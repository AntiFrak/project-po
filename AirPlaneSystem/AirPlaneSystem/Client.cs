using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    abstract class Client : Company
    {
        private List<Flight> tickets = new List<Flight>();

        public void BuyTicket(Flight f)
        {
            tickets.Add(f);
        }

        public void DeleteTicket(int i)
        {
            tickets.RemoveAt(i);
        }

        public Flight GetMyTicket(int i)
        {
            return tickets[i];
        }

        public List<Flight> GetAllTickets()
        {
            return tickets;
        }
    }
}
