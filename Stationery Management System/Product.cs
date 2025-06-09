using System.ComponentModel.DataAnnotations;

namespace Stationery_Management_System
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string? ImagePath { get; set; }
    }

}
