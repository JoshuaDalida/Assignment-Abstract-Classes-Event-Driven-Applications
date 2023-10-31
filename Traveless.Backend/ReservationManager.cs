using Intents;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entites;

namespace BlazorHybridApp.Traveless.Backend
{
   
    internal class ReservationManager
    {
        public int AvailableSeats(Flights flight) //This one
        {
            return flight.TotalSeats;
        }

        public Reservation FindReservationByCode(string code) 
        {
            foreach (Reservation reservation in _reservations)
                {
                    if (reservation.Code == code)
                    {
                        return reservation;
                    }
                }
            Console.WriteLine("Reservation Not Found");
            return null;
        }

        //public Reservation(string Code, Flights Flight, string Name, string Citizenship, bool IsActive) NEEDS IS ACTIVE
        public Reservation MakeReservation(Flights flight, string name, string citizenship) 
        {
            Reservation reservation = new Reservation(flight.Code, flight , name , citizenship,true);
            return reservation;
        }

        public string RESERVATIONS_JSON_FILE = "JSON FILES\reservation.csv";

        public void Save() 
        {
            string filePath = RESERVATIONS_JSON_FILE;
            using (StreamWriter writer = new StreamWriter(filePath))
                foreach (Reservation reservation in _reservations)
                {
                    writer.WriteLine(reservation.ToString);
                }
        }

        public ReservationManager() { }

        protected IList<Reservation> _reservations; 
        protected void LoadFromFile()
        {
            string[] data = File.ReadAllLines(RESERVATIONS_JSON_FILE);
            foreach (string line in data)
            {
                string[] coloums = line.Split(";");

                //public Reservation(string Code, Flights Flight, string Name, string Citizenship, bool IsActive)
                Reservation reservation = new Reservation
                (
                    coloums[0],//code
                    coloums[1], //flight
                    coloums[2], //name
                    coloums[3], //citizenship
                    bool.Parse(coloums[4])// isActive
                );

                _reservations.Add( reservation );
            }
        }
    }
}
