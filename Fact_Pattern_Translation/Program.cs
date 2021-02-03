/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: main.cs
 * Description: Driver for program, calls ShapeFactory class and IGeometricShape to ensure they are functioning properly
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Pattern_Translation
{
    enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }

    class Program
    {
        static void Main(string[] args)
        {
            //For counting placement in the enumeration which will be passed to ShapeFactory
            int place = 0;
            
            //For calling ShapeFactory functions
            ShapeFactory shapes = new ShapeFactory();

            while (place < 4)
            {
                IGeometricShape output = shapes.getShape((ShapeType)place);

                //Catch for the triangle shape that is not implemented
                if (output == null)
                {
                    Console.WriteLine("Apologies, but the Shape Factory could not produce the given shape.");
                }

                //Incrementation to prevent the loop from infitely running, definitely didn't forget this on my first test run...
                place++;
            }
            //Allows user to view window without it immediately closing
            Console.ReadKey();
        }
    }
}
