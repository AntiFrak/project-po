using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneSystem
{
    class PrivatePerson : Client
    {
        public string Name
        {
            get;
        }
        public string Surname
        {
            get;
        }
        public string Pesel
        {
            get;
        }
        public PrivatePerson(string name, string surname, string pesel)
        {
            Name = name;
            Surname = surname;
            Pesel = pesel;
        }
    }
}
