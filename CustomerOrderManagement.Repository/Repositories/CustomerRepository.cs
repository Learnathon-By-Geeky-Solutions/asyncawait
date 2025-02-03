using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Repository.Abstractions;
using System.Collections.Generic;
using System.Linq;
using EFCoreSamples.Database;

namespace CustomerOrderManagement.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerOrderDbContext _context;

        public CustomerRepository(CustomerOrderDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
