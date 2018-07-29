/*
Car Salesman
Define two classes Car and Engine. A Car has a model, engine, weight and color. An Engine has model, power,
displacement and efficiency. A Car’s weight and color and its Engine’s displacements and efficiency are optional.
On the first line you will read a number N which will specify how many lines of engines you will receive. On each of
the next N lines you will receive information about an Engine in the following format “&lt;Model&gt; &lt;Power&gt;
&lt;Displacement&gt; &lt;Efficiency&gt;”. After the lines with engines, on the next line you will receive a number M –
specifying the number of Cars that will follow. On each of the next M lines information about a Car will follow in the
format “&lt;Model&gt; &lt;Engine&gt; &lt;Weight&gt; &lt;Color&gt;”, where the engine will be the model of an existing Engine. When
creating the object for a Car, you should keep a reference to the real engine in it, instead of just the engine’s model.
Note that the optional properties might be missing from the formats.
Your task is to print each car (in the order you received them) and its information in the format defined bellow, if
any of the optional fields has not been given print “n/a” in its place instead:
&lt;CarModel&gt;:
&lt;EngineModel&gt;:
Power: &lt;EnginePower&gt;
Displacement: &lt;EngineDisplacement&gt;
Efficiency: &lt;EngineEfficiency&gt;
Weight: &lt;CarWeight&gt;
Color: &lt;CarColor&gt;
Bonus*
Override the classes’ ToString() methods to have a reusable way of displaying the objects.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int engineNum = 0; engineNum < numOfEngines; engineNum++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 2)
                {
                    string engineModel = input[0];
                    string enginePower = input[1];

                    engines.Add(new Engine(engineModel, enginePower));
                }
                else if (input.Length == 3)
                {
                    string engineModel = input[0];
                    string enginePower = input[1];
                    double engineDisplacement;
                    bool isEngineDisplacement = double.TryParse(input[2], out engineDisplacement);
                    if (isEngineDisplacement)
                    {
                        engines.Add(new Engine(engineModel, enginePower, engineDisplacement));
                    }
                    else
                    {
                        string engineEfficiency = input[2];
                        engines.Add(new Engine(engineModel, enginePower, engineEfficiency));
                    }
                }
                else if (input.Length == 4)
                {
                    string engineModel = input[0];
                    string enginePower = input[1];
                    double engineDisplacement = double.Parse(input[2]);
                    string engineEfficiency = input[3];

                    engines.Add(new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency));
                }
            }

            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int carNum = 0; carNum < numOfCars; carNum++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 2)
                {
                    string carModel = input[0];
                    Engine carEngine = engines.Where(e => e.Model == input[1]).First();

                    cars.Add(new Car(carModel, carEngine));
                }
                else if (input.Length == 3)
                {
                    string carModel = input[0];
                    Engine carEngine = engines.Where(e => e.Model == input[1]).First();
                    double weight;
                    bool isWeight = double.TryParse(input[2], out weight);
                    if (isWeight)
                    {
                        cars.Add(new Car(carModel, carEngine, weight));
                    }
                    else
                    {
                        string color = input[2];
                        cars.Add(new Car(carModel, carEngine, color));
                    }

                    
                }
                else if (input.Length == 4)
                {
                    string carModel = input[0];
                    Engine carEngine = engines.Where(e => e.Model == input[1]).First();
                    int weight = int.Parse(input[2]);
                    string color = input[3];

                    cars.Add(new Car(carModel, carEngine, weight, color));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}