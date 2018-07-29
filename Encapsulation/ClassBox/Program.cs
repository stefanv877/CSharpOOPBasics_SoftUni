/*
Class Box
You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be
instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral
surface area and its volume (formulas: http://www.mathwords.com/r/rectangular_parallelepiped.htm).
On the first three lines you will get the length, width and height. On the next three lines print the surface area,
lateral surface area and the volume of the box.
*/


using System;


class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Box box = new Box(lenght, width, height);

        Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {box.Volume():F2}");
    }
}


