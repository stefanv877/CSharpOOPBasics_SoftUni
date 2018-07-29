/*
Company Roster
Define a class Employee that holds the following information: name, salary, position, department, email and age.
The name, salary, position and department are mandatory while the rest are optional.
Your task is to write a program which takes N lines of employees from the console and calculates the department
with the highest average salary and prints for each employee in that department his name, salary, email and age –
sorted by salary in descending order. If an employee doesn’t have an email – in place of that field you should print
“n/a” instead, if he doesn’t have an age – print “-1” instead. The salary should be printed to two decimal places
after the seperator.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];


                if (input.Length == 4)
                {
                    employees[i] = new Employee(name, salary, position, department);
                }
                else if (input.Length == 5)
                {
                    int age;
                    bool isAge = int.TryParse(input[4], out age);
                    if (isAge)
                    {
                        employees[i] = new Employee(name, salary, position, department, age);
                    }
                    else
                    {
                        string email = input[4];
                        employees[i] = new Employee(name, salary, position, department, email);
                    }
                }
                else
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);
                    employees[i] = new Employee(name, salary, position, department, email, age);
                }
            }

            Dictionary<string, decimal> departmentsAndSalaries = new Dictionary<string, decimal>();

            foreach (Employee employee in employees)
            {
                if (departmentsAndSalaries.ContainsKey(employee.Department))
                {
                    departmentsAndSalaries[employee.Department] += employee.Salary;
                }
                else
                {
                    departmentsAndSalaries[employee.Department] = employee.Salary;
                }
            }

            decimal highestAverageSalay = 0;
            string highestPaidDepartment = string.Empty;

            foreach (var department in departmentsAndSalaries.Keys)
            {
                decimal averageSalaryPerDepartment = departmentsAndSalaries[department] / employees.Where(d => d.Department == department).Count();
                if (averageSalaryPerDepartment > highestAverageSalay)
                {
                    highestAverageSalay = averageSalaryPerDepartment;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");

            foreach (Employee employee in employees.Where(e => e.Department == highestPaidDepartment).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}