using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AM.ApplicationCore.InMemorySource;

namespace AM.ApplicationCore.Service
{
    public class FlightService : IFlightService
    {
        ICollection<Flight> a;
        ShowLine showLine = new ShowLine(Console.WriteLine);
        public FlightService(List<Flight> source , ShowLine showline) {

            a = source;
            showLine= showline;
        }

        public void ShowFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in a)
                    {
                        if (flight.Destination == (filterValue) )
                        {
                            showLine(filterType+filterValue);
                            showLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    DateTime y = DateTime.Parse(filterValue);
                    foreach (var flight in a)
                    {
                        if (flight.FlightDate == y )
                        {
                            Console.WriteLine(filterType + filterValue);
                            showLine(flight);
                        }
                    }
                    break;
                case "FlightId":

                    int m = int.Parse(filterValue);
                    foreach (var flight in a)
                    {
                        if (flight.flightId == m)
                        {
                            Console.WriteLine(filterType + filterValue);
                            showLine(flight);
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Unknown filter");
            }





        }
    
    





}


}
