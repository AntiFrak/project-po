using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    abstract class Client
    {
        private List<Flight> tickets = new List<Flight>();

        public void BuyTicket(Flight f, int seats)
        {
            if (seats > f.Ap.Capacity)
            {
                Console.WriteLine("End of seats!!! Availble " + f.Ap.Capacity + " seats.");
            }
            else
            {
                tickets.Add(f);
                f.Ap.Capacity--;
            }
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
