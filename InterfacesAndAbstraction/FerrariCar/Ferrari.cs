using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    public string DriverName { get; private set; }

    public string Model { get => "488-Spider"; }

    public Ferrari(string name)
    {
        this.DriverName = name;
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{Model}/{UseBrakes()}/{PushGas()}/{DriverName}";
    }
}
