/*
Rectangle Intersection
Create a class Rectangle. It should consist of an id, width, height and the coordinates of its top left corner
(horizontal and vertical). Create a method which receives as a parameter another Rectangle, checks if the two
rectangles intersect and returns true or false.
On the first line you will receive the number of rectangles – N and the number of intersection checks – M. On the
next N lines, you will get the rectangles with their id, width, height and coordinates. On the last M lines, you will get
pairs of ids which represent rectangles. Print if each of the pairs intersect.
You will always receive valid data. There is no need to check if a rectangle exists.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace RectangleIntersection
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int numberOfRectangles = int.Parse(input[0]);
            int intersectionChecks = int.Parse(input[1]);

            List<Rectangle> rectagles = new List<Rectangle>();

            for (int recatngelNum = 0; recatngelNum < numberOfRectangles; recatngelNum++)
            {
                string[] data = Console.ReadLine().Split();
                string id = data[0];
                double width = double.Parse(data[1]);
                double height = double.Parse(data[2]);
                double startX = double.Parse(data[3]);
                double startY = double.Parse(data[4]);

                rectagles.Add(new Rectangle(id, width, height, startX, startY));
            }

            for (int interChecks = 0; interChecks < intersectionChecks; interChecks++)
            {
                string[] data = Console.ReadLine().Split();
                string check1 = data[0];
                string check2 = data[1];

                Rectangle currentRectangle = rectagles.Where(r => r.Id == check1).First();

                currentRectangle.IsIntersect(rectagles.Where(r => r.Id == check2).First());
            }
        }
    }
}