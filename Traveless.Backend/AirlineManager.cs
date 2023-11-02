using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlazorHybridApp.Traveless.Backend.Entites;

namespace BlazorHybridApp.Traveless.Backend
{
    internal class AirlineManager
    {
        public AirlineManager() { }

        public IList<Airline> Airlines { get; }

        public string AIRLINE_FILE = "JSON FILES\airline.csv";
        public Airline FindAirline(string code)
        {
            foreach (Airline airline in Airlines)
                if (airline.Code == code)
                {
                    return airline;
                }
            return null;
        }



        protected List<Airline> _airlines;

        protected void LoadAirlines()
        {
            string[] data = File.ReadAllLines(AIRLINE_FILE);
            foreach (string line in data)
            {
                string[] coloums = line.Split(";");
                //public Airline(string code, string name)
                Airline airline = new Airline
                    (
                    coloums[0],//code
                    coloums[1]
                    );
                _airlines.Add( airline );
            }
        }
    }
}
