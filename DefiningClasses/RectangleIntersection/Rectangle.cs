using System;
using System.Collections.Generic;
using System.Text;


class Rectangle
{
    string id;
    double width;
    double height;
    double startX;
    double startY;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double StartX
    {
        get { return startX; }
        set { startX = value; }
    }

    public double StartY
    {
        get { return startY; }
        set { startY = value; }
    }

    public Rectangle(string id, double width, double height, double startX, double startY)
    {
        Id = id;
        Width = width;
        Height = height;
        StartX = startX;
        StartY = startY;
    }

    public void IsIntersect(Rectangle rectangle)
    {
        if (rectangle.StartX + rectangle.Width >= StartX && rectangle.StartX <= StartX + Width
            && rectangle.StartY >= StartY - Height && rectangle.StartY - rectangle.Height <= StartY)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
