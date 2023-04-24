using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Ticket : IEquatable<Ticket>
    {
        // property to store the duration of the ticket hours
        public int DurationInHours { get; set; }

        //simple constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours; // returns True or False
        }

    }
}
