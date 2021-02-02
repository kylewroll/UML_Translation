/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: IDumb.cs
 * Description: File containing IDumb interface and related classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Fact_Translation
{
    //Interface for dumbphone
    interface IDumb
    {
        //Returns name of dumbphone, basically a prototype
        string getName();
    }

    //Looks the same as the ISmart classes, just with different names, which suffices for this project
    class Asha : IDumb
    {
        //Implementation of getName from parent interface
        string IDumb.getName()
        {
            return "Asha";
        }
    }

    class Genie : IDumb
    {
        //Implementation of getName from parent interface
        string IDumb.getName()
        {
            return "Genie";
        }
    }

    class Primo : IDumb
    {
        //Implementation of getName from parent interface
        string IDumb.getName()
        {
            return "Primo";
        }
    }
}
