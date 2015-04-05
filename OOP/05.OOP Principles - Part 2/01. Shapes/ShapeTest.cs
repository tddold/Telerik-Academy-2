//Problem 1. Shapes
//Define abstract class Shape with only one abstract method CalculateSurface()
//and fields width and height.Define two new classes Triangle and Rectangle that implement the virtual method
//and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal
//to width and implement the CalculateSurface() method. Write a program that tests the behaviour 
//of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

namespace shape
{
    using System;
    using System.Collections.Generic;
    public class ShapeTest
    {
        static void Main()
        {

            var shapes = new Shape[]
            { 
                new Rectangle(3, 2),
                new Triangle(3, 3),
                new Square(3)
            };
            foreach (var figure in shapes)
            {
                Console.WriteLine("The figure is {0} and its surface is {1}",figure.ToString(),figure.CalculateSurface());
            }
        }
    }
}