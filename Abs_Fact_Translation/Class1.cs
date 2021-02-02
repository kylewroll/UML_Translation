/*Author: Kyle Rolland
 * Date: 2/2/2021
 * File: Phone_Type_Checker.cs
 * Description: File that contains the PhoneTypeChecker class, which is pivotal to running the program
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Fact_Translation
{

    class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;

        //Sets factory dependent on certain manufacturer, and sets manu equal to that manufacturer
        public void phoneTypeChecker(Manufacturers m)
        {

            //I'm sure there was a better way to implement this, like maybe with a switch statement? But my brain is a little slow to fire today, and this was the first way that came to me,
            //and it works so I'm sticking with it. The printing is hard coded, so it doesn't need to catch any poor user input.

            //Manufacturers are set in the same order that they appear in the enumeration located in Main
            if (m == (Manufacturers)0) //format for right hand side of if statement was based on MSDN article
            {
                factory = new SamsungFactory();
                manu = m;
            }

            else if (m == (Manufacturers)1)
            {
                factory = new NokiaFactory();
                manu = m;
            }

            else if (m == (Manufacturers)2)
            {
                factory = new HTCFactory();
                manu = m;
            }
        }

        //Prints out manufacturer and name of smart and dumb phones. Creates ISmart and IDumb variables to hold names for printing
        public void checkProducts()
        {
            Console.WriteLine("Manufacturer: " + manu);

            ISmart smartPhone = factory.GetSmart(); //Tried testing wihout this statement and it just printed out the class names, which wasn't good
            Console.WriteLine("Smartphone: " + smartPhone.getName());

            IDumb dumbPhone = factory.GetDumb();
            Console.WriteLine("Dumbphone: " + dumbPhone.getName());
        }
    }
}
