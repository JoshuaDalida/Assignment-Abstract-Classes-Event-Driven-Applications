using AssetsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entites;

namespace BlazorHybridApp.Traveless.Backend
{
    internal class FlightManager
    {
        
        public Flights FindFlightByCode(string code)
        {
            foreach (Flights flight in _flights) 
            {
                if (flight.Code == code) 
                {
                    return flight;
                }
                
            }
            Console.WriteLine("flight not found");
            return null;
        }

        public FlightManager() { }

        public IList<Flights> Flights { get; }

        private string FLIGHTS_FILE = "JSON FILES\flights.csv";

        protected List<Flights> _flights;

        protected void LoadFlights() 
        {
            string[] data = File.ReadAllLines(FLIGHTS_FILE);
            foreach (string line in data)
            {
                string[] coloums = line.Split(";");
                //public Flights(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
                Flights flights = new Flights
                    (
                    coloums[0], 
                    coloums[1],
                    coloums[2], 
                    coloums[3], 
                    coloums[4],
                    int.Parse(coloums[5]), 
                    Decimal.Parse(coloums[6])
                    );
                
            }
        }
    }

}

