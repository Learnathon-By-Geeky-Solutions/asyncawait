using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Repository.Abstractions;
using CustomerOrderManagement.Services.Abstractions;
using System.Collections.Generic;

namespace CustomerOrderManagement.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
            _customerRepository.Save();
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
            _customerRepository.Save();
        }
    }
}
