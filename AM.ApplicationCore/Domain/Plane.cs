using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }

        public int Planed { get; set; }

        public PlaneType  PlaneType { get; set; }
        public int PlaneId { get;  set; }

        public IList<Flight> Flights { get; set; }  

        public Plane()
        {

        }

       public Plane(int cap ,DateTime mani, PlaneType plan 
           )
        {
            Capacity = cap;
            ManifactureDate = mani;
            PlaneType = plan;


        }

        public override string ToString()
        {
            return $"{Capacity} {ManifactureDate}";
        }


    }


}
