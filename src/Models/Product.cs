using System.ComponentModel.DataAnnotations;

namespace Docker.NetCore.SqlServer.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}