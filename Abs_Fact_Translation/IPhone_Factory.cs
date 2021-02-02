/* Author: Kyle Rolland
 * Date: 2/2/2021
 * File: IPhone_Factory.cs
 * Description: File containing IPhoneFactory interface and related classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Fact_Translation
{
    //Interface that determines which manufacturer gets which phones
    interface IPhoneFactory
    {
        //Felt similar to making function prototypes. Not sure if this is how you intended this to be implemented but I read the interfaces had the ability to do this, so I wanted to take advantage
        
        //Returns smartphone type, ISmart
        ISmart GetSmart(); 

        //Returns dumbphone type, IDumb
        IDumb GetDumb();
    }

    //All combinations of smartphones and dumbphones are hard coded here
    class SamsungFactory : IPhoneFactory
    {
        //Implementation of GetSmart from parent interface
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart smartPhone = new Lumia();
            return smartPhone;
        }

        //Implementation of GetDumb from parent interface
        IDumb IPhoneFactory.GetDumb()
        {
            IDumb dumbPhone = new Asha();
            return dumbPhone;
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        //Implementation of GetSmart from parent interface
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart smartPhone = new Titan();
            return smartPhone;
        }

        //Implementation of GetDumb from parent interface
        IDumb IPhoneFactory.GetDumb()
        {
            IDumb dumbPhone = new Primo();
            return dumbPhone;
        }
    }

    class HTCFactory : IPhoneFactory
    {
        //Implementation of GetSmart from parent interface
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart smartPhone = new GalaxyS2();
            return smartPhone;
        }

        //Implementation of GetDumb from parent interface
        IDumb IPhoneFactory.GetDumb()
        {
            IDumb dumbPhone = new Genie();
            return dumbPhone;
        }
    }
}
