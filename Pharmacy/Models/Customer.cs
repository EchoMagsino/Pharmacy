using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public char? MI { get; set; }

        public string ContactNumber { get; set; }
    }
}
