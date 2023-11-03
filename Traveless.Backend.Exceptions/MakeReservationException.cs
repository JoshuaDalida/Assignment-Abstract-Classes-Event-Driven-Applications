using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp.MakeReservationException
{
    internal class MakeReservationException : Exception
    {

        public MakeReservationException() { }

        public MakeReservationException(string message) : base("Invalid Reservation") 
        {
        
        }
    }
}
