/*
Mankind
Your task is to model an application. It is very simple. The mandatory models of our application are 3: Human,
Worker and Student.
The parent class – Human should have first name and last name. Every student has a faculty number. Every worker
has a week salary and work hours per day. It should be able to calculate the money he earns by hour. You can see
the constraints below.
Input
On the first input line you will be given info about a single student - a name and faculty number.
On the second input line you will be given info about a single worker - first name, last name, salary and working
hours.
Output
You should first print the info about the student following a single blank line and the info about the worker in the
given formats:
 Print the student info in the following format:
First Name: {student&#39;s first name}
Last Name: {student&#39;s last name}
Faculty number: {student&#39;s faculty number}
 Print the worker info in the following format:
First Name: {worker&#39;s first name}
Last Name: {worker&#39;s second name}
Week Salary: {worker&#39;s salary}
Hours per day: {worker&#39;s working hours}
Salary per hour: {worker&#39;s salary per hour}
Print exactly two digits after every double value&#39;s decimal separator (e.g. 10.00). Consider the workweek from
Monday to Friday. A faculty number should be consisted only of digits and letters.
Constraints
Human first Should start with a capital &quot;Expected upper case letter! Argument: firstName&quot;
name letter
Human first
name

Should be more than 3
symbols

&quot;Expected length at least 4 symbols! Argument: firstName&quot;

Human last name Should start with a capital

letter &quot;Expected upper case letter! Argument: lastName&quot;

Human last name Should be more than 2

symbols

&quot;Expected length at least 3 symbols! Argument: lastName &quot;

Faculty number Should be in range [5..10]

symbols

&quot;Invalid faculty number!&quot;

Week salary Should be more than 10 &quot;Expected value mismatch! Argument: weekSalary&quot;
Working hours Should be in the range [1..12] &quot;Expected value mismatch! Argument: workHoursPerDay&quot;
*/


using System;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] workerInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student newStudent = new Student(studentInput[0], studentInput[1], studentInput[2]);
                Worker newWorker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]),
                                              double.Parse(workerInput[3]));

                Console.WriteLine(newStudent);
                Console.WriteLine();
                Console.WriteLine(newWorker);
            }
            catch (Exception exArgsStudent)
            {
                Console.WriteLine(exArgsStudent.Message);                
            }
        }
    }
}