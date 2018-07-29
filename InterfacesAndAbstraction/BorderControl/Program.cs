/*
Border Control
It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re
afraid of rebellions you decide to implement strict control of who enters your city. Your soldiers check the Ids of
everyone who enters and leaves.
You will receive an unknown amount of lines from the console until the command “End” is received, on each line
there will be a piece of information for either a citizen or a robot who tries to enter your city in the format “&lt;name&gt;
&lt;age&gt; &lt;id&gt;” for citizens and “&lt;model&gt; &lt;id&gt;” for robots. After the end command on the next line you will receive a
single number representing the last digits of fake ids, all citizens or robots whose Id ends with the specified digits
must be detained.
The output of your program should consist of all detained Ids each on a separate line in the order of input.
Input
The input comes from the console. Every commands’ parameters before the command “End” will be separated by a
single space.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizens> citizens = new List<Citizens>();
            //List<Robots> robots = new List<Robots>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs.Length == 2)
                {
                    var robotModel = commandArgs[0];
                    var robotId = commandArgs[1];

                    citizens.Add(new Citizens(robotModel, robotId));
                }
                else
                {
                    var citizenName = commandArgs[0];
                    var citizenAge = commandArgs[1];
                    var citizenId = commandArgs[2];

                    citizens.Add(new Citizens(citizenName, citizenAge, citizenId));
                }
            }

            string idsEndWith = Console.ReadLine();

            foreach (var item in citizens.Where(x => x.Id.EndsWith(idsEndWith)))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}