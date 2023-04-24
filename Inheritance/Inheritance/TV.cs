using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Child Class
    class TV : Device
    {
        //simple constructor
        //use base keyword to pass isOn and brand to base class constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        //watch TV
        public void WatchTV()
        {
            //check if TV is on
            if (IsOn)
            {
                //watch TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch on to watch.");
            }
        }
    }
}
