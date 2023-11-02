using System;
namespace BlazorHybridApp.Traveless.Backend.Entites;

//Needs to finish both equals methods
public class Reservation
{
    private string citizenship;
    public string code;
    private bool isActive;
    private string name;
    private Flights flight;

    public string Citizenship { get; set; }
    public string Code { get; set; }
    public Flights Flights { get; set; }
    public string Name { get; set; }
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    public bool Equals(Object obj) { return true; }
    public bool Equals(Reservation other) { return true; }
    public string GenerateReservationCode(Flights flight) 
    { 
        return flight.AirlineCode; 
    }
    public Reservation() { }

    public Reservation(string Code, Flights Flight, string Name, string Citizenship, bool IsActive)
    {
        code = Code;
        flight = Flight;
        name = Name;
        citizenship = Citizenship;
        isActive = IsActive;
    }

    public override string ToString()
    {
        return $"{code},{flight},{name},{citizenship},{isActive}";
    }



}


