using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Models.ViewModels.Customers;
using CustomerOrderManagement.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CustomerOrderManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetAll();
            var model = new CustomerIndexViewModel
            {
                Customers = customers.ToList()
            };
            return View(model);
        }

        public ViewResult Create()
        {
            var model = new CustomerCreateViewModel
            {
                Customers = _customerService.GetAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer
                {
                    Name = model.Name,
                    PhoneNo = model.PhoneNo,
                    Address = model.Address,
                    CategoryId = 1
                };

                _customerService.Add(customer);
                return RedirectToAction("Index");
            }

            model.Customers = _customerService.GetAll().ToList();
            return View(model);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var customer = _customerService.GetById(id.Value);
            if (customer == null)
            {
                return View("NotFound");
            }

            var model = new CustomerEditViewModel
            {
                Id = customer.Id,
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                Address = customer.Address
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CustomerEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var existingCustomer = _customerService.GetById(model.Id);
            if (existingCustomer == null)
            {
                return View("NotFound");
            }

            existingCustomer.Name = model.Name;
            existingCustomer.PhoneNo = model.PhoneNo;
            existingCustomer.Address = model.Address;

            _customerService.Update(existingCustomer);
            return RedirectToAction("Index");
        }
    }
}
