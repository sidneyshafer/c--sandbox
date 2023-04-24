using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Child Class
    class Radio : Device
    {
        //simple constructor
        //use base keyword to pass isOn and brand to base class constructor
        public Radio(bool isOn, string brand):base(isOn, brand)
        {

        }

        //listen to the radio
        public void ListenRadio()
        {
            //check if radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch on to listen.");
            }
        }
    }
}
