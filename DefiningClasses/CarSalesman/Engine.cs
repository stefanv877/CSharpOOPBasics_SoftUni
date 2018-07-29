using System;
using System.Collections.Generic;
using System.Text;


class Engine
{
    string model;
    string power;
    double displacement = 0;
    string efficiency = "n/a";

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Power
    {
        get { return power; }
        set { power = value; }
    }

    public double Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

    public Engine (string model, string power)
    {
        Model = model;
        Power = power;
    }

    public Engine(string model, string power, double displacement)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
    }

    public Engine(string model, string power, string efficiency)
    {
        Model = model;
        Power = power;
        Efficiency = efficiency;
    }

    public Engine(string model, string power, double displacement, string efficiency)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }
}
