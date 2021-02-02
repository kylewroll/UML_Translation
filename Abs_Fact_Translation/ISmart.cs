/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: ISmart.cs
 * Description: File containing ISmart implementation and related classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Fact_Translation
{
    //Figuring out the order of how to return and fit in all of these data types was confusing at first, but then I came up with the idea of implementing it the way that I did below, and it helped

    //Interface for smartphone
    interface ISmart
    {
       
        //Returns name of smartphone, essentially just a prototype
        string getName();
    }

    //Easiest classes I've ever had to make. Let's hope that's not a sign that I did this wrong...
    class Lumia : ISmart
    {
       
        //Implementation of getName from parent interface
        string ISmart.getName()
        {
            return "Lumia";
        }
    }

    class GalaxyS2 : ISmart
    {
        //Implementation of getName from parent interface
        string ISmart.getName()
        {
            return "GalaxyS2";
        }
    }

    class Titan : ISmart
    {
        //Implementation of getName from parent interface
        string ISmart.getName()
        {
            return "Titan";
        }
    }
}
