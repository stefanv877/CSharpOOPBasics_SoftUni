/*
Ferrari
Model an application which contains a class Ferrari and an interface. Your task is simple, you have a car - Ferrari, its
model is &quot;488-Spider&quot; and it has a driver. Your Ferrari should have functionality to use brakes and push the gas
pedal. When the brakes are pushed down print &quot;Brakes!&quot;, and when the gas pedal is pushed down - &quot;Zadu6avam
sA!&quot;. As you may have guessed this functionality is typical for all cars, so you should implement an interface to
describe it.
Your task is to create a Ferrari and set the driver&#39;s name to the passed one in the input. After that, print the info.
Take a look at the Examples to understand the task better.
Input
On the single input line, you will be given the driver&#39;s name.
Output
On the single output line, print the model, the messages from the brakes and gas pedal methods and the driver&#39;s
name. In the following format:
&lt;model&gt;/&lt;brakes&gt;/&lt;gas pedal&gt;/&lt;driver&#39;s name&gt;
Constraints
The input will always be valid, no need to check it explicitly! The Driver&#39;s name may contain any ASCII characters.
*/


using System;

namespace FerrariCar
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Ferrari car = new Ferrari(name);

            Console.WriteLine(car);
        }
    }
}