using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Repository.Abstractions;
using System.Collections.Generic;
using System.Linq;
using EFCoreSamples.Database;

namespace CustomerOrderManagement.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CustomerOrderDbContext _context;

        public ProductRepository(CustomerOrderDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
