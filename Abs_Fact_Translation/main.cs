/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: Main.cs
 * Description: Main driver for the translation of the abstract factory pattern Dia file into code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Fact_Translation
{
    //The enumeration was giving me some trouble at first, but I got it sorted out in time
    enum Manufacturers
    {
        SAMSUNG,
        NOKIA,
        HTC
    }

    class main
    {
        static void Main(string[] args)
        {
            int place = 0;
            PhoneTypeChecker phone = new PhoneTypeChecker();

            while (place < 3)
            {
                phone.phoneTypeChecker((Manufacturers)place);
                phone.checkProducts();
                Console.WriteLine();
                
                place++;
            }

            Console.ReadKey();
        }
    }
}
