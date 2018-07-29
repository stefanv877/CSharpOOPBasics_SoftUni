/*
Opinion Poll
Using the Person class, write a program that reads from the console N lines of personal information and then prints
all people whose age is more than 30 years, sorted in alphabetical order.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                if (age > 30)
                {
                    people.Add(new Person(name, age));
                }
            }

            foreach (var person in people.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}