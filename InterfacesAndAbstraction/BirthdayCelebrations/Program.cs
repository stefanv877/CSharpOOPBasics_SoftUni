/*
Birthday Celebrations
It is a well known fact that people celebrate birthdays, it is also known that some people also celebrate their pets’
birthdays. Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a
name and a birthdate. Encompass repeated functionality into interfaces and implement them in your classes.
You will receive from the console an unknown amount of lines. Until the command “End” is received, each line will
contain information in one of the following formats “Citizen &lt;name&gt; &lt;age&gt; &lt;id&gt; &lt;birthdate&gt;” for citizens, “Robot
&lt;model&gt; &lt;id&gt;” for robots or “Pet &lt;name&gt; &lt;birthdate&gt;” for pets. After the “End” command on the next line you will
receive a single number representing a specific year, your task is to print all birthdates (of both citizens and pets) in
that year in the format day/month/year in the order of input.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizens> citizens = new List<Citizens>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandArgs[0])
                {
                    case "Citizen":
                        var humanName = commandArgs[1];
                        var humanAge = commandArgs[2];
                        var humanId = commandArgs[3];
                        var humanBday = commandArgs[4];

                        citizens.Add(new Human(humanName, humanAge, humanId, humanBday));
                        break;

                    case "Robot":
                        var robotModel = commandArgs[1];
                        var robotId = commandArgs[2];
                        break;

                    case "Pet":
                        var petName = commandArgs[1];
                        var petBday = commandArgs[2];

                        citizens.Add(new Pet(petName, petBday));
                        break;

                    default:
                        break;
                }
            }

            string bdayEndWith = Console.ReadLine();

            foreach (var item in citizens.Where(x => x.Birthdate.EndsWith(bdayEndWith)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}