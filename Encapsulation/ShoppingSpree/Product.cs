using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private decimal cost;

    public string Name
    {
        get { return name; }
    }
    
    public decimal Cost
    {
        get { return cost; }
    }

    public Product(string name, decimal cost)
    {
        if (!string.IsNullOrWhiteSpace(name)) this.name = name;
        else throw new ArgumentException("Name cannot be empty");
        this.cost = cost;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}
