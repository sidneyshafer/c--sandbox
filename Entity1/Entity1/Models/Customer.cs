using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; // CANNOT allow null values
        public string LastName { get; set; } = null!; // CANNOT allow null values
        public string? Address { get; set; } // can allow null values
        public string? Phone { get; set; }  // can allow null values
        public string? Email { get; set; }
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
