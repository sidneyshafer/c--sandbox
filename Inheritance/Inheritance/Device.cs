using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Parent - Base Class
    class Device
    {

        // CLASS PROPERTIES

        //boolean to determine the state of the device
        public bool IsOn { get; set; }

        //string for the brand name of the device
        public string Brand { get; set; }

        //simple constructor
        public Device(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        //CLASS METHODS

        //switch the device on
        public void SwitchOn()
        {
            IsOn = true;
        }

        //switch the device off
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
