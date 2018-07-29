using System;
using System.Collections.Generic;
using System.Text;

class Cargo
{
    private int weight;
    private string type;

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public void CargoInfo(string weight, string type)
    {
        Weight = int.Parse(weight);
        Type = type;
    }
}
