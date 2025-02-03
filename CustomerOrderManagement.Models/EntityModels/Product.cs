using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrderManagement.Models.EntityModels
{
    public class Product
    {
        public Product() { }

        public Product(string name, string description, double unitPrice, int categoryId)
        {
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")] 
        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }

        public ProductCategory Category { get; set; } 
    }
}
