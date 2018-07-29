/*
Vehicles
Write a program that models 2 vehicles (Car and Truck) and simulates driving and refueling them. Car and truck
both have fuel quantity, fuel consumption in liters per km and can be driven a given distance and refueled with a
given amount of fuel. It’s summer, so both vehicles use air conditioners and their fuel consumption per km is
increased by 0.9 liters for the car and with 1.6 liters for the truck. Also, the truck has a tiny hole in its tank and when
its refueled it keeps only 95% of the given fuel. The car has no problems and adds all the given fuel to its tank. If a
vehicle cannot travel the given distance, its fuel does not change.
Input
 On the first line – information about the car in the format: &quot;Car {fuel quantity} {liters per km}&quot;
 On the second line – info about the truck in the format: &quot;Truck {fuel quantity} {liters per km}&quot;
 On the third line – the number of commands N that will be given on the next N lines
 On the next N lines – commands in the format:
 &quot;Drive Car {distance}&quot;
 &quot;Drive Truck {distance}&quot;
 &quot;Refuel Car {liters}&quot;
 &quot;Refuel Truck {liters}&quot;
Output
 After each Drive command, if there was enough fuel, print on the console a message in the format:
 &quot;Car/Truck travelled {distance} km&quot;
 If there was not enough fuel, print: &quot;Car/Truck needs refueling&quot;
 After the End command, print the remaining fuel for both the car and the truck, rounded to 2 digits after the
floating point in the format:
 &quot;Car: {liters}&quot;
 &quot;Truck: {liters}&quot;
*/


using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var truckInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

            var n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Drive":
                        switch (commands[1])
                        {
                            case "Car":
                                car.DriveDistance(double.Parse(commands[2]));
                                break;

                            case "Truck":
                                truck.DriveDistance(double.Parse(commands[2]));
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Refuel":
                        switch (commands[1])
                        {
                            case "Car":
                                car.Refuel(double.Parse(commands[2]));
                                break;

                            case "Truck":
                                truck.Refuel(double.Parse(commands[2]));
                                break;

                            default:
                                break;
                        }
                        break;
                }

                n--;
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
