﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using BlazorHybridApp.Traveless.Backend.Entites;
=======
using Traveless.Backend.Entites;
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd

namespace BlazorHybridApp.Traveless.Backend
{
    internal class AirportManager
    {
        public AirportManager() { }

        public IList<Airport> airports { get; }

        public string AIRPORT_FILE = "JSON FILES\airports.csv";

        protected IList<Airport> _airports;

<<<<<<< HEAD
        protected void LoadAirports()
=======
        protected void LoadAirports() 
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd
        {
            string[] data = File.ReadAllLines(AIRPORT_FILE);
            foreach (string line in data)
            {
                string[] coloums = line.Split(";");
                //public Airline(string code, string name)
                Airport airport = new Airport
                    (
                    coloums[0],//code
                    coloums[1]//name
                    );
                _airports.Add(airport);
            }
<<<<<<< HEAD
        }
=======
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd
    }
}
