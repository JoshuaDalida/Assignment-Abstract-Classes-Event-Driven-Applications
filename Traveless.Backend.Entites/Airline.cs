using System;
<<<<<<< HEAD
namespace BlazorHybridApp.Traveless.Backend.Entites;
=======
namespace Traveless.Backend.Entites;
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd

public class Airline
{
	private string _code;
	private string _name;

	public string Code { get; set; }
	public string Name { get; set; }
	public Airline(string code, string name)
	{
		_code = code;
		_name = name;
	}

    public override string ToString()
    {
<<<<<<< HEAD
		return $"{_code};{_name}";  
=======
		return $"{_code};{_name}";
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd
    }
}
