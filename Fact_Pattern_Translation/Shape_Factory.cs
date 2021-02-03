/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: Shape_Factory.cs
 * Description: File containing ShapeFactory class, utilizes IGeometricShape interface to call shapes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Pattern_Translation
{
    class ShapeFactory
    {
        public IGeometricShape getShape(ShapeType type)
        {
            //I had hoped switch statement could operate off of integer values that are automatically assigned to the items in the enumeration, but as will be seen later, it was not the case
            switch(type)
            {
                //First object in enumeration, a line
                //Explicit casts from here on out because Visual Studio was upset without them
                case (ShapeType)0:

                    //Create new line shape, named line, for calling draw function, and returning
                    IGeometricShape line = new Line();

                    Console.WriteLine("Current shape being drawn is a " + (ShapeType)type);
                    line.draw();

                    //All of the WriteLine's after the function calls are just to help with readability once everything is printed
                    Console.WriteLine();

                    return line;

                //Second object in enumeration, a circle
                
                case (ShapeType)1:

                    //Create new circle shape, named circle, for calling draw function, and returning
                    IGeometricShape circle = new Circle();

                    Console.WriteLine("Current shape being drawn is a " + (ShapeType)type);
                    circle.draw();

                    Console.WriteLine();

                    return circle;

                //Third object in enumeration, a rectangle
                case (ShapeType)2:

                    //Create new rectangle shape, named rectangle, for calling draw function, and returning
                    IGeometricShape rectangle = new Rectangle();

                    Console.WriteLine("Current shape being drawn is a " + (ShapeType)type);
                    rectangle.draw();

                    Console.WriteLine();

                    return rectangle;

                default:

                    //Catch for any shapes not implemented, like triangle, returns null which will be caught by main
                    Console.WriteLine("ERROR: Shape not implemented");
                    return null;
            }
        }

    }
}
