using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Travellar : Passenger
    {
       public String HealthInformation { get; set; }
       
       public String Nationality { get; set; }


        public override string ToString()
        {
            return $"{HealthInformation} {Nationality}";
        }

        public override string PassengerType
        {
            get { return "Traveller passenger type"; }
        }
    }
}
