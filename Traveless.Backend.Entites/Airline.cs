﻿using System;
namespace BlazorHybridApp.Traveless.Backend.Entites;

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
		return $"{_code};{_name}";
    }
}
