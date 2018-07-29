using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    const double airConditionerFuelConsIncrease = 0.9;

    public Car(double fuelQuantity, double fuelConsumption) 
        : base(fuelQuantity, fuelConsumption)
    {
        this.FuelConsumption += airConditionerFuelConsIncrease;
    }

    public override void DriveDistance(double distance)
    {
        if (this.FuelQuantity < distance * FuelConsumption)
        {
            Console.WriteLine($"Car needs refueling");

        }
        else
        {
            this.FuelQuantity -= (this.FuelConsumption * distance);
            Console.WriteLine($"Car travelled {distance} km");
        }
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        var result = $"Car: {FuelQuantity:F2}";
        return result;
    }
}
