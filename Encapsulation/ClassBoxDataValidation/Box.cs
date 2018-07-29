using System;
using System.Collections.Generic;
using System.Text;


internal class Box
{
    private double length;
    private double width;
    private double height;

    internal Box(double length, double width, double height)
    {
        if (length > 0) this.length = length;
        else throw new ArgumentException("Length cannot be zero or negative.");

        if (width > 0) this.width = width;
        else throw new ArgumentException("Width cannot be zero or negative.");

        if (height > 0) this.height = height;
        else throw new ArgumentException("Height cannot be zero or negative.");
    }

    public double SurfaceArea()
    {
        return 2 * length * width + 2 * length * height + 2 *width * height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * length * height + 2 * width * height;
    }

    public double Volume()
    {
        return length * width * height;
    }
}
