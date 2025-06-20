using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineID { get; set; }

        public string? GenericName { get; set; }

        public string? BrandName { get; set; }

        public double BuyPrice { get; set; }

        public double SellPrice { get; set; }

        public string? UsedFor { get; set; }

    }
}
