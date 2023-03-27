using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }

        public String EmailAdress { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PassportNumber { get; set; }

        public String TelNumber { get; set; }

        public IList<Flight> flights { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual string PassengerType
        {
            get { return "Unknown passenger type"; }
        }
    }
}
