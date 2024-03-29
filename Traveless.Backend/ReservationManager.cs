﻿
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorHybridApp.Traveless.Backend.Entites;
using System.Text.Json;


namespace BlazorHybridApp.Traveless.Backend
{
   
    internal class ReservationManager
    {
        //needs finishing
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
        public Reservation MakeReservation( string flightCode,string name, string citizenship) 
        {
            FlightManager flightManager = new FlightManager();
            Flights flight = flightManager.FindFlightByCode(flightCode);

            
            
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            char letter = letters[random.Next(letters.Length)];
            string randomDigits = new string(Enumerable.Repeat(digits, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            string reservationCode = $"{letter}{randomDigits}";


            Reservation madeReservation = new Reservation(reservationCode, flight, name, citizenship,true);
            Reservations.Add(madeReservation);
            return madeReservation;
        }
        public string CSVFilePath
        {
            get
            {
                
                string currentDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(currentDir, "JSON FILES\\reservation.csv");

                return filePath;
            }
        }
       

        public void Save() 
        {
            string filePath = CSVFilePath;
            using (StreamWriter writer = new StreamWriter(filePath))
                foreach (Reservation reservation in Reservations)
                {
                    writer.WriteLine(reservation.ToString());
                }
        }

        public ReservationManager() 
        {
            _reservations = new List<Reservation>();
            
        }

        public IList<Reservation> Reservations
        {
            get { return _reservations; }
        }

        protected List<Reservation> _reservations; 
        protected void LoadFromFile()
        {
            

            string[] lines = File.ReadAllLines(this.CSVFilePath);

           foreach (string line in lines)
           {
                string[] coloums = line.Split(",");

                Flights flight = new Flights();
                    
                Reservation reservation = new Reservation
                (
                coloums[0],//code
                flight, //flight
                coloums[2], //name
                coloums[3], //citizenship
                bool.Parse(coloums[4])// isActive
           );

           Reservations.Add(reservation);
           }
            


        }



    }
}
