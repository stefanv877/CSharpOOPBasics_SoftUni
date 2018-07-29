/*
Raw Data
You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a
class Car that holds information about model, engine, cargo and a collection of exactly 4 tires. The engine, cargo
and tire should be separate classes. Create a constructor that receives all information about the Car and creates and
initializes its inner components (engine, cargo and tires).
On the first line of input you will receive a number N - the amount of cars you have. On each of the next N lines you
will receive information about a car in the format “&lt;Model&gt; &lt;EngineSpeed&gt; &lt;EnginePower&gt; &lt;CargoWeight&gt;
&lt;CargoType&gt; &lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt; &lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt;
&lt;Tire4Pressure&gt; &lt;Tire4Age&gt;” where the speed, power, weight and tire age are integers, tire pressure is a double.
After the N lines you will receive a single line with one of 2 commands: “fragile” or “flamable”. If the command is
“fragile” print all cars whose Cargo Type is “fragile” with a tire whose pressure is &lt; 1. If the command is “flamable”
print all cars whose Cargo Type is “flamable” and have Engine Power &gt; 250. The cars should be printed in order of
appearing in the input.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int amountOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int carcounter = 0; carcounter < amountOfCars; carcounter++)
            {
                string[] input = Console.ReadLine().Split();

                Engine currentEngine = new Engine();
                Cargo currentCargo = new Cargo();
                Tire currentTires = new Tire();

                var currentModel = input[0];
                currentEngine.EngineInfo(input[1], input[2]);
                currentCargo.CargoInfo(input[3], input[4]);
                currentTires.TireInfo(input[5], input[6], input[7], input[8], input[9], input[10], input[11], input[12]);

                Car currentCar = new Car(currentModel, currentEngine, currentCargo, currentTires);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command).Where(c => c.Tires.Tire1Pressure < 1
                                                                                        || c.Tires.Tire2Pressure < 1
                                                                                        || c.Tires.Tire3Pressure < 1
                                                                                        || c.Tires.Tire4Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command).Where(c => c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}