using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AM.ApplicationCore.InMemorySource;

namespace AM.ApplicationCore
{
    public static class InMemorySource
    {
        public static Plane Boeing1 { get; private set; } = GetFirstPlane();

        public static readonly Plane Boeing2 = new Plane(150, new DateTime(2015, 02, 03), PlaneType.Boeing) { Flights = new List<Flight>() { f3, f4 }, PlaneId = 2 };
        public static readonly Plane Airbus = new Plane { PlaneId = 3, PlaneType = PlaneType.Airbus, Capacity = 250, ManifactureDate = new DateTime(2020, 11, 11), Flights = new List<Flight>() { f5, f6 } };
        public static readonly Staff s1 = new Staff { BirthDate = new DateTime(1965, 01, 01), FirstName = "captain", LastName = "Captain", EmailAdress = "captain@gmail.com", EmployementDate = new DateTime(1999, 01, 01), Salary = 10000, flights = new List<Flight>() { f1 } };
        public static readonly Staff s2 = new Staff { BirthDate = new DateTime(1995, 01, 01), FirstName = "hotess1", LastName = "Hotess1", EmailAdress = "hotess1@gmail.com", EmployementDate = new DateTime(2019, 01, 01), Salary = 5000, flights = new List<Flight>() { f1 } };
        public static readonly Staff s3 = new Staff { BirthDate = new DateTime(1995, 01, 01), FirstName = "hotess2", LastName = "Hotess2", EmailAdress = "hotess2@gmail.com", EmployementDate = new DateTime(2018, 01, 01), Salary = 6100, flights = new List<Flight>() { f1 } };
        public static readonly Travellar t1 = new Travellar { FirstName = "traveller1", LastName = "Traveller1", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "No troubles", Nationality = "American", flights = new List<Flight>() { f2 } };
        public static readonly Travellar t2 = new Travellar { FirstName = "traveller2", LastName = "Traveller2", BirthDate = new DateTime(1981, 01, 01), HealthInformation = "Some troubles", Nationality = "French", flights = new List<Flight>() { f2 } };
        public static readonly Travellar t3 = new Travellar { FirstName = "traveller3", LastName = "Traveller3", BirthDate = new DateTime(1982, 01, 01), HealthInformation = "No troubles", Nationality = "Tunisian", flights = new List<Flight>() { f2 } };
        public static readonly Travellar t4 = new Travellar { FirstName = "traveller4", LastName = "Traveller4", BirthDate = new DateTime(1983, 01, 01), HealthInformation = "Some troubles", Nationality = "American", flights = new List<Flight>() { f2 } };
        public static readonly Travellar t5 = new Travellar { FirstName = "traveller5", LastName = "Traveller5", BirthDate = new DateTime(1984, 01, 01), HealthInformation = "Some troubles", Nationality = "Spanish", flights = new List<Flight>() { f2 } };

        public static List<Staff> staffs = new List<Staff>() { s1, s2, s3 };
        public static List<Travellar> Travellers = new List<Travellar>() { t1, t2, t3, t4, t5 };


        public static readonly Flight f1 = new Flight { flightId = 1, FlightDate = new DateTime(2022, 01, 01, 15, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 0), EstimatedDuration = 2f, plane = Boeing1, passengers = new List<Passenger>() { s1, s2, s3 } };
        public static readonly Flight f2 = new Flight { flightId = 2, FlightDate = new DateTime(2022, 02, 01, 21, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 0), EstimatedDuration = 2f, plane = Boeing1, passengers = new List<Passenger>() { t1, t2, t3, t4, t5 } };
        public static readonly Flight f3 = new Flight { plane = Boeing2, flightId = 3, FlightDate = new DateTime(2022, 03, 01, 5, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 03, 01, 7, 10, 0), EstimatedDuration = 2f, passengers = passengers() };
        public static readonly Flight f4 = new Flight { plane = Boeing2, flightId = 4, FlightDate = new DateTime(2022, 04, 01, 6, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 04, 01, 8, 40, 0), EstimatedDuration = 2.5f };
        public static readonly Flight f5 = new Flight { plane = Airbus, flightId = 5, FlightDate = new DateTime(2022, 05, 01, 17, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 05, 01, 19, 40, 0), EstimatedDuration = 2.5f };
        public static readonly Flight f6 = new Flight { plane = Airbus, flightId = 6, FlightDate = new DateTime(2022, 06, 01, 20, 10, 0), Destination = "Lisbonne", EffectiveArrival = new DateTime(2022, 06, 01, 23, 10, 0), EstimatedDuration = 3f };

        public static List<Flight> Flights = new List<Flight>() { f1, f2, f3, f4, f5, f6 };

        static Plane GetFirstPlane()
        {
            Plane plane = new Plane();
            plane.PlaneId = 1;
            plane.PlaneType = PlaneType.Boeing;
            plane.ManifactureDate = new DateTime(2019, 12, 31);
            plane.Flights = new List<Flight>() { f1, f2 };
            return plane;
        }
       public  static List<Passenger> passengers()
        {
            List<Passenger> p = new List<Passenger>() { s1, s2, s3, t1, t2, t3, t4, t5 };
            return p;
        }

        public delegate void ShowLine(Object flight);


        
    }

    public static class CoreExtension
    {
        public static void ShowList<T>(this IEnumerable<T> items, string title, ShowLine showline)
        {
            showline(title);
            foreach (var item in items)
            {
                showline(item.ToString());
            }
        }
    }
}
