using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public String Depature { get; set; }

        public String Destination { get; set; }

        public DateTime EffectiveArrival { get; set; }

        public float EstimatedDuration { get; set; }

        public DateTime FlightDate  { get; set; }

        public int flightId { get; set; }

        public Plane plane { get; set; }

        public IList<Passenger> passengers { get; set; }

        public override string ToString()
        {
            return $"{EffectiveArrival} {Depature}";
        }




    }
}
