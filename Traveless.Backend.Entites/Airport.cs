﻿using System;
<<<<<<< HEAD
namespace BlazorHybridApp.Traveless.Backend.Entites;
=======
namespace Traveless.Backend.Entites;
>>>>>>> 7ac5359e5aa13acbd74ef94776ffd15cfddbcecd

public class Airport
{
    private string _code;
    private string _name;

    public string Code { get; set; }
    public string Name { get; set; }
    public Airport(string code, string name)
    {
        _code = code;
        _name = name;
    }

    public override string ToString()
    {
        return $"Code: {_code}, Name: {_name}";
    }
}
