using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    const double airConditionerFuelConsIncrease = 1.6;
    const double fuelLeak = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption) 
        : base(fuelQuantity, fuelConsumption)
    {
        this.FuelConsumption += airConditionerFuelConsIncrease;
    }

    public override void DriveDistance(double distance)
    {
        if (this.FuelQuantity < distance * FuelConsumption)
        {
            Console.WriteLine($"Truck needs refueling");
        }
        else
        {
            this.FuelQuantity -= (this.FuelConsumption * distance);
            Console.WriteLine($"Truck travelled {distance} km");
        }
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += (fuel * fuelLeak);
    }

    public override string ToString()
    {
        var result = $"Truck: {FuelQuantity:F2}";
        return result;
    }
}
