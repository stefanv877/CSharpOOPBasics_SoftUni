/*
Class Box Data Validation
A box’s side should not be zero or a negative number. Expand your class from the previous problem by adding data
validation for each parameter given to the constructor. Make a private setter that performs data validation
internally.
*/


using System;


class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            Box box = new Box(lenght, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}


