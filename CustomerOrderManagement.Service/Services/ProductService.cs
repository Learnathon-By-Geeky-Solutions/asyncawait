using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Repository.Abstractions;
using CustomerOrderManagement.Services.Abstractions;
using System.Collections.Generic;

namespace CustomerOrderManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }
    }
}
