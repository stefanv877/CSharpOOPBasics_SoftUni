/*
Oldest Family Member
Use your Person class from the previous tasks. Create a class Family. The class should have list of people, a method
for adding members (void AddMember(Person member)) and a method returning the oldest family member
(Person GetOldestMember()). Write a program that reads the names and ages of N people and adds them to the
family. Then print the name and age of the oldest member.
*/

using System;

namespace OldestFamilyMember
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}