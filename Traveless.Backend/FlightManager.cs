
using System.Text.Json;
using BlazorHybridApp.Traveless.Backend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace BlazorHybridApp.Traveless.Backend
{
    internal class FlightManager
    {

        public Flights FindFlightByCode(string code)
        {
            foreach (Flights flight in Flight) 
            {
                if (flight.Code == code) 
                {
                    return flight;
                }
   
            }
            Console.WriteLine("flight not found");
            return null;
        }

        public FlightManager() 
        {
            Flight = LoadFlights();
        }

        public IList<Flights> Flight { get; }

        private string FLIGHTS_FILE = "C:\\Users\\joshu\\OneDrive\\Desktop\\BlazorHybridApp\\JSON FILES\\flights.csv";

        protected List<Flights> _flights;

        protected List <Flights> LoadFlights() 
        {
            List<Flights> flights = new List<Flights>();
            string[] data = File.ReadAllLines(FLIGHTS_FILE);
            foreach (string line in data)
            {
                string[] coloums = line.Split(",");
                //TB-4017(0),Try a Bus Airways(1),ATL(2),FRA(3),Monday(4),18:30(5),174(6),1444.00(7)
                //public Flights(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
                Flights flight = new Flights
                    (
                    coloums[0], //code
                    coloums[1],//airlineCode
                    coloums[2],//from
                    coloums[3], //to
                    coloums[4], //weekday
                    coloums[5],//time
                    int.Parse(coloums[6]),//seats 
                    Decimal.Parse(coloums[7])//costPerSeat
                    );
                flights.Add(flight);
               
            }
            return flights;
        }
    }

}

