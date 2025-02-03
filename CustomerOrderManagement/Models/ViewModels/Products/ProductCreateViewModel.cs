using CustomerOrderManagement.Models.CustomValidators;
using CustomerOrderManagement.Models.EntityModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerOrderManagement.Models.ViewModels.Products
{
    public class ProductCreateViewModel
    {
        [Required(ErrorMessage = "Please provide the Product Name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide the Product Price!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please provide a description!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please provide a Category ID!")]
        public int Id { get; set; }

        public List<Product>? Products { get; set; }
    }
}
