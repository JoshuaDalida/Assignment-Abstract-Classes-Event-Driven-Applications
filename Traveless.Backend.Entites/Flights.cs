﻿using System;
<<<<<<< HEAD
namespace BlazorHybridApp.Traveless.Backend.Entites;
=======
namespace Traveless.Backend.Entites;
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd
public class Flights

	// NEEDS BOTH EQUALS METHODS
{
	private string _code;
	private decimal _costPerSeat;
	private string _from;
    private string _time;
	private string _to;
	private int _totalSeats;
	private string _weekDay;

	public string AirlineCode { get; }
	public string Code { get; set; }
	public decimal CostPerSeat { get; set; }
	public int FlightNumber { get;}
	public string From { get; set; }
	public bool IsDomestic { get; }
	public string Time { get; set; }
	public string To { get; set; }
	public int TotalSeats { get; set; }
	public string WeekDay { get; set; }

	public bool Equals(Flights other) { return true; }
	public bool Equals(object obj) { return true; }

	public Flights()
	{ 
	
	}

<<<<<<< HEAD
	public Flights(string code, string airlineCode, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
	{
		Code = code;
		AirlineCode = airlineCode;
=======
	public Flights(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
	{
		Code = code;
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd
		From = from;
		To = to;
		WeekDay = weekday;
		Time = time;
		TotalSeats = seats;
        CostPerSeat = costPerSeat;
	} 
}
