/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: I_Geometric_Shape
 * Description: File containing IGeometricShape interface and its child classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Pattern_Translation
{
    //I made this project second, after the abstract factory, and everything seems so simple and fast now that I know what to do
    interface IGeometricShape
    {
        //Prototype version of draw function
        void draw();
    }

    class Line : IGeometricShape
    {
        //Implementation of draw() from parent interface
        void IGeometricShape.draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }

    class Circle : IGeometricShape
    {
        //Implementation of draw() from parent interface
        void IGeometricShape.draw()
        {
            Console.WriteLine("Circle is drawn");
        }
    }

    class Rectangle : IGeometricShape
    {
        //Implementation of draw() from parent interface
        void IGeometricShape.draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }
    }
}
