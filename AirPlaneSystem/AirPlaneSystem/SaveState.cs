using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AirPlaneSystem
{
    class SaveState
    {
        public static void saveToDrive(Company data, string nameOfFile)
        {
            TextWriter save = new StreamWriter(nameOfFile + ".txt");
            foreach (Airplane a in data.GetAllAirplanes())
            {
                save.WriteLine("Airplane|" + a.Name + "|" + a.Id + "|" + a.Capacity);
            }
            save.WriteLine(" ");
            foreach (Airport ap in data.GetAllAirports())
            {
                save.WriteLine("Airpport|" + ap.Name + "|" + ap.CoordX + "|" + ap.CoordY);
            }
            save.WriteLine(" ");
            foreach (Client p in data.GetAllClients())
            {
                if (p is PrivatePerson)
                {
                    PrivatePerson pp = (PrivatePerson)p;
                    save.WriteLine("Private Person|" + pp.Name + "|" + pp.Surname + "|" + pp.Pesel);
                }
                else if (p is FlightAgent)
                {
                    FlightAgent fa = (FlightAgent)p;
                    save.WriteLine("Flight Agent|" + fa.Name + "|" + fa.IdNumber);
                }
            }
            save.WriteLine(" ");
            foreach (Flight f in data.GetAllFlights())
            {
                save.WriteLine("Flights|" + f.From.Name + "|" + f.To.Name + "|" + f.Date + "|" + f.Ap.Name + "|" + f.ArrivalDate.ToString("yyyy-MM-dd"));
            }
            save.Close();
        }
    }
}
